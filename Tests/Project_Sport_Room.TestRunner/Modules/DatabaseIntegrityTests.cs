using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Project_Sport_Room.Models;

namespace Project_Sport_Room.TestRunner.Modules
{
    public class DatabaseIntegrityTests
    {
        [TestCase("TC-MOD8-001", "DB Integrity", "Foreign Key Cascade Delete: Category Deletion", "DB Integrity")]
        public async Task Test_Category_CascadeDelete()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Water Sports" };
            var eq = new Equipment { Name = "Life Jacket", Quantity = 10, Category = cat };

            db.Categories.Add(cat);
            db.Equipments.Add(eq);
            await db.SaveChangesAsync();

            db.Categories.Remove(cat);
            await db.SaveChangesAsync();

            var remainingEq = await db.Equipments.FirstOrDefaultAsync(e => e.Id == eq.Id);
            Assert.Null(remainingEq, "Equipments should be cascade deleted when Category is deleted");
        }

        [TestCase("TC-MOD8-002", "DB Integrity", "Foreign Key Constraint: Invalid DepartmentId on Borrower", "Negative")]
        public async Task Test_Borrower_InvalidDepartmentFk()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var borrower = new Borrower("Student", "STU_FK_ERR")
            {
                Name = "Invalid Dept Student",
                DepartmentId = "DEP_NON_EXISTENT",
                Email = "test@invalid.com",
                PhoneNumber = "0000000000"
            };

            db.Borrowers.Add(borrower);

            var ex = await Assert.ThrowsAsync<DbUpdateException>(async () =>
            {
                await db.SaveChangesAsync();
            });

            Assert.NotNull(ex);
        }

        [TestCase("TC-MOD8-003", "DB Integrity", "Foreign Key Constraint: IntakeItem Supplier FK", "Negative")]
        public async Task Test_IntakeItem_InvalidSupplierFk()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Racket Sports" };
            var eq = new Equipment { Name = "Shuttlecock Box", Quantity = 20, Category = cat };
            db.Categories.Add(cat);
            db.Equipments.Add(eq);
            await db.SaveChangesAsync();

            var intake = new IntakeItem
            {
                EquipmentId = eq.Id,
                SupplierId = "SUPP_DOES_NOT_EXIST",
                Quantity = 5,
                BrokenQty = 0,
                SuppliedDate = DateTime.Now
            };

            db.IntakeItems.Add(intake);

            var ex = await Assert.ThrowsAsync<DbUpdateException>(async () =>
            {
                await db.SaveChangesAsync();
            });

            Assert.NotNull(ex);
        }

        [TestCase("TC-MOD8-004", "DB Integrity", "SQLite Online Backup VACUUM INTO Snapshot Integrity", "Functional / DB Integrity")]
        public async Task Test_SQLite_OnlineBackup_Snapshot()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Archery" };
            var eq = new Equipment { Name = "Recurve Bow", Quantity = 7, BrokenQty = 1, Category = cat };
            db.Categories.Add(cat);
            db.Equipments.Add(eq);
            await db.SaveChangesAsync();

            // Create temporary backup file path
            string tempBackupPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"srms_test_backup_{Guid.NewGuid():N}.db");
            try
            {
                string escapedPath = tempBackupPath.Replace("'", "''");
#pragma warning disable EF1002
                await db.Database.ExecuteSqlRawAsync($"VACUUM INTO '{escapedPath}';");
#pragma warning restore EF1002

                // Verify file exists and is not empty
                Assert.True(System.IO.File.Exists(tempBackupPath), "Backup file should be created");
                var fileInfo = new System.IO.FileInfo(tempBackupPath);
                Assert.True(fileInfo.Length > 0, "Backup file should contain data");

                // Verify SQLite 3 magic header
                byte[] header = new byte[16];
                using (var stream = new System.IO.FileStream(tempBackupPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    await stream.ReadAsync(header, 0, 16);
                }
                string headerStr = System.Text.Encoding.ASCII.GetString(header);
                Assert.True(headerStr.StartsWith("SQLite format 3"), "Snapshot must be valid SQLite 3 format");

                // Open backup and verify data was preserved
                using var backupContext = new TestSportRoomContext($"Data Source={tempBackupPath}");
                var backedUpEq = await backupContext.Equipments.FirstOrDefaultAsync(e => e.Name == "Recurve Bow");
                Assert.NotNull(backedUpEq);
                if (backedUpEq != null)
                {
                    Assert.Equal(7, backedUpEq.Quantity);
                    Assert.Equal(1, backedUpEq.BrokenQty);
                }
            }
            finally
            {
                if (System.IO.File.Exists(tempBackupPath))
                {
                    try { System.IO.File.Delete(tempBackupPath); } catch { }
                }
            }
        }
    }
}
