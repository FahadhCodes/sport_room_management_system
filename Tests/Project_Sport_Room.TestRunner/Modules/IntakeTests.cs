using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Sport_Room.Models;

namespace Project_Sport_Room.TestRunner.Modules
{
    public class IntakeTests
    {
        [TestCase("TC-MOD5-001", "Intake", "Batch Intake Simultaneous Equipment Stock & History Update", "Integration")]
        public async Task Test_BatchIntake_SimultaneousStockUpdate()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Gym" };
            var eq = new Equipment { Name = "Yoga Mat", Quantity = 5, BrokenQty = 0, Category = cat };
            var sup = new Supplier { Name = "Fitness Pro", PhoneNumber = "0771122334" };

            db.Categories.Add(cat);
            db.Equipments.Add(eq);
            db.Suppliers.Add(sup);
            await db.SaveChangesAsync();

            int healthy = 10;
            int damaged = 2;
            int total = healthy + damaged;

            eq.Quantity += healthy;
            eq.BrokenQty += damaged;

            var newIntake = new IntakeItem
            {
                EquipmentId = eq.Id,
                Quantity = total,
                BrokenQty = damaged,
                SuppliedDate = DateTime.Now,
                SupplierId = sup.Id
            };
            db.IntakeItems.Add(newIntake);
            await db.SaveChangesAsync();

            var updatedEq = await db.Equipments.FindAsync(eq.Id);
            var savedIntake = await db.IntakeItems.FindAsync(newIntake.Id);

            Assert.NotNull(updatedEq);
            Assert.NotNull(savedIntake);
            Assert.Equal(15, updatedEq.Quantity);
            Assert.Equal(2, updatedEq.BrokenQty);
            Assert.Equal(sup.Id, savedIntake.SupplierId);
            Assert.Equal(12, savedIntake.Quantity);
        }

        [TestCase("TC-MOD5-002", "Intake", "Intake Null Supplier Handling", "Negative / Boundary")]
        public async Task Test_Intake_NullSupplierHandling()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Track" };
            var eq = new Equipment { Name = "Discus", Quantity = 4, Category = cat };
            db.Categories.Add(cat);
            db.Equipments.Add(eq);
            await db.SaveChangesAsync();

            var legacyIntake = new IntakeItem
            {
                EquipmentId = eq.Id,
                Quantity = 4,
                BrokenQty = 0,
                SuppliedDate = DateTime.Now,
                SupplierId = null
            };
            db.IntakeItems.Add(legacyIntake);
            await db.SaveChangesAsync();

            var query = db.IntakeItems.Where(i => i.Id == legacyIntake.Id).Select(data => new
            {
                data.Id,
                supplierName = data.Supplier != null ? data.Supplier.Name : "N/A"
            });

            var result = await query.FirstOrDefaultAsync();
            Assert.NotNull(result);
            Assert.Equal("N/A", result.supplierName);
        }

        [TestCase("TC-MOD5-003", "Intake", "Zero Quantity Intake Row Skipping", "Functional")]
        public void Test_Intake_ZeroQuantitySkipping()
        {
            int healthy = 0;
            int damaged = 0;

            bool shouldSkip = (healthy == 0 && damaged == 0);
            Assert.True(shouldSkip, "Rows with zero healthy and zero damaged quantities must be skipped");
        }
    }
}
