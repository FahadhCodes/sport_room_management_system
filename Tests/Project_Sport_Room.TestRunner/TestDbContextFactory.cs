using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Project_Sport_Room.Models;

namespace Project_Sport_Room.TestRunner
{
    public class TestSportRoomContext : SportRoomContext
    {
        [ThreadStatic]
        public static string? ActiveConnectionString;

        public TestSportRoomContext(string connectionString)
        {
            ActiveConnectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(ActiveConnectionString))
            {
                optionsBuilder.UseSqlite(ActiveConnectionString);
            }
            else
            {
                base.OnConfiguring(optionsBuilder);
            }
        }
    }

    public class IsolatedTestDatabase : IDisposable
    {
        public string DbFilePath { get; }
        public string ConnectionString { get; }

        public IsolatedTestDatabase()
        {
            DbFilePath = Path.Combine(Path.GetTempPath(), $"test_sportroom_{Guid.NewGuid():N}.db");
            ConnectionString = $"Data Source={DbFilePath}";
            TestSportRoomContext.ActiveConnectionString = ConnectionString;

            using (var db = CreateContext())
            {
                db.Database.EnsureCreated();
            }
        }

        public TestSportRoomContext CreateContext()
        {
            TestSportRoomContext.ActiveConnectionString = ConnectionString;
            return new TestSportRoomContext(ConnectionString);
        }

        public void Dispose()
        {
            try
            {
                Microsoft.Data.Sqlite.SqliteConnection.ClearAllPools();
                GC.Collect();
                GC.WaitForPendingFinalizers();

                if (File.Exists(DbFilePath)) File.Delete(DbFilePath);
                string shm = $"{DbFilePath}-shm";
                string wal = $"{DbFilePath}-wal";
                if (File.Exists(shm)) File.Delete(shm);
                if (File.Exists(wal)) File.Delete(wal);
            }
            catch
            {
            }
        }
    }
}
