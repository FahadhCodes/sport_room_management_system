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
    }
}
