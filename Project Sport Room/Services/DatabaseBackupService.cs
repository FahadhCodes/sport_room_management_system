using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Project_Sport_Room.Models;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Sport_Room.Services
{
    public static class DatabaseBackupService
    {
        /// <summary>
        /// Resolves the absolute path to the active SQLite database file.
        /// </summary>
        public static string GetDatabaseFilePath()
        {
            string localDb = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sportroom.db");
            if (File.Exists(localDb)) return localDb;

            string cwdDb = Path.GetFullPath("sportroom.db");
            if (File.Exists(cwdDb)) return cwdDb;

            return localDb;
        }

        /// <summary>
        /// Returns the default Backups directory, creating it if necessary.
        /// </summary>
        public static string GetDefaultBackupDirectory()
        {
            string backupDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backups");
            if (!Directory.Exists(backupDir))
            {
                Directory.CreateDirectory(backupDir);
            }
            return backupDir;
        }

        /// <summary>
        /// Backs up the active database to the specified target file using SQLite's online VACUUM INTO engine.
        /// </summary>
        public static async Task BackupDatabaseAsync(string targetFilePath)
        {
            if (string.IsNullOrWhiteSpace(targetFilePath))
                throw new ArgumentException("Target file path cannot be empty.", nameof(targetFilePath));

            string? dir = Path.GetDirectoryName(targetFilePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // SQLite VACUUM INTO requires the target file to not exist beforehand
            if (File.Exists(targetFilePath))
            {
                File.Delete(targetFilePath);
            }

            using (var db = new SportRoomContext())
            {
                string escapedPath = targetFilePath.Replace("'", "''");
#pragma warning disable EF1002 // VACUUM INTO requires literal path in SQLite grammar
                await db.Database.ExecuteSqlRawAsync($"VACUUM INTO '{escapedPath}';");
#pragma warning restore EF1002
            }
        }

        /// <summary>
        /// Creates an automatic timestamped backup and cleans up rolling backups older than 14 days.
        /// </summary>
        public static async Task<string> CreateAutoBackupAsync(string prefix = "auto_exit")
        {
            try
            {
                string backupDir = GetDefaultBackupDirectory();
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HHmmss");
                string backupPath = Path.Combine(backupDir, $"{prefix}_{timestamp}.db");

                await BackupDatabaseAsync(backupPath);
                CleanOldBackups(backupDir, daysToKeep: 14);

                return backupPath;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Restores the database from a backup file after verifying SQLite integrity and creating a safety copy.
        /// </summary>
        public static async Task RestoreDatabaseAsync(string sourceBackupFilePath)
        {
            if (!File.Exists(sourceBackupFilePath))
                throw new FileNotFoundException("Backup file not found.", sourceBackupFilePath);

            // 1. Verify SQLite header format
            byte[] header = new byte[16];
            using (var stream = new FileStream(sourceBackupFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                if (stream.Length < 16)
                    throw new InvalidOperationException("The selected file is not a valid SQLite database (file too small).");

                int bytesRead = await stream.ReadAsync(header, 0, 16);
                if (bytesRead < 16)
                    throw new InvalidOperationException("Failed to read header from the backup file.");
            }

            string headerString = Encoding.ASCII.GetString(header);
            if (!headerString.StartsWith("SQLite format 3"))
            {
                throw new InvalidOperationException("The selected file is not a valid SQLite database file.");
            }

            // 2. Take a safety backup of the current database before replacing
            await CreateAutoBackupAsync("auto_pre_restore");

            // 3. Clear all active connection pools to release Windows file locks
            SqliteConnection.ClearAllPools();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // 4. Overwrite active database file
            string targetDbPath = GetDatabaseFilePath();
            string walPath = targetDbPath + "-wal";
            string shmPath = targetDbPath + "-shm";

            File.Copy(sourceBackupFilePath, targetDbPath, overwrite: true);

            if (File.Exists(walPath))
            {
                try { File.Delete(walPath); } catch { }
            }

            if (File.Exists(shmPath))
            {
                try { File.Delete(shmPath); } catch { }
            }

            // 5. Warm up EF Core and verify database health
            using (var testDb = new SportRoomContext())
            {
                await testDb.Equipments.CountAsync();
            }
        }

        private static void CleanOldBackups(string backupDir, int daysToKeep = 14)
        {
            try
            {
                var dirInfo = new DirectoryInfo(backupDir);
                DateTime cutoff = DateTime.Now.AddDays(-daysToKeep);

                var oldFiles = dirInfo.GetFiles("*.db")
                    .Where(f => (f.Name.StartsWith("auto_exit_") || f.Name.StartsWith("auto_pre_restore_")) && f.CreationTime < cutoff);

                foreach (var file in oldFiles)
                {
                    try { file.Delete(); } catch { }
                }
            }
            catch { }
        }
    }
}
