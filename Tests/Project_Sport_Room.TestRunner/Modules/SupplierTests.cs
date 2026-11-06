using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Sport_Room.Models;

namespace Project_Sport_Room.TestRunner.Modules
{
    public class SupplierTests
    {
        [TestCase("TC-MOD4-001", "Supplier", "Supplier Summary with Zero Supplied Items", "Boundary")]
        public async Task Test_SupplierSummary_ZeroItems()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var sup = new Supplier { Name = "Atlas Sports", PhoneNumber = "0113334444" };
            db.Suppliers.Add(sup);
            await db.SaveChangesAsync();

            var supplierData = await db.Suppliers.Where(s => s.Id == sup.Id)
                .Select(val => new { val.Name, val.PhoneNumber }).ToListAsync();

            var totalSuppliedQty = await db.IntakeItems.Where(item => item.SupplierId == sup.Id)
                .Select(sel => new { sel.Quantity }).ToListAsync();

            int tot = totalSuppliedQty.Sum(item => item.Quantity);

            Assert.Equal(1, supplierData.Count);
            Assert.Equal("Atlas Sports", supplierData[0].Name);
            Assert.Equal(0, tot);
        }

        [TestCase("TC-MOD4-002", "Supplier", "Non-Existent Supplier ID Null Safety", "Negative")]
        public async Task Test_Supplier_InvalidIdNullSafety()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            string invalidId = "SUPP_NONEXISTENT";
            var supplierData = await db.Suppliers.Where(s => s.Id == invalidId)
                .Select(val => new { val.Name, val.PhoneNumber }).ToListAsync();

            // Safe navigation: FirstOrDefault()?.Name should NOT throw NullReferenceException
            string? name = supplierData.FirstOrDefault()?.Name;
            string? phone = supplierData.FirstOrDefault()?.PhoneNumber;

            Assert.Null(name);
            Assert.Null(phone);
        }

        [TestCase("TC-MOD4-003", "Supplier", "Supplier Intake Date Range Filtering", "Functional")]
        public async Task Test_Supplier_DateRangeFilter()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Aquatics" };
            var eq = new Equipment { Name = "Goggles", Quantity = 20, Category = cat };
            var sup = new Supplier { Name = "Speedo Lanka", PhoneNumber = "0115556666" };
            db.Categories.Add(cat);
            db.Equipments.Add(eq);
            db.Suppliers.Add(sup);

            var item1 = new IntakeItem { Equipment = eq, Supplier = sup, SuppliedDate = new DateTime(2026, 1, 15), Quantity = 10 };
            var item2 = new IntakeItem { Equipment = eq, Supplier = sup, SuppliedDate = new DateTime(2026, 6, 20), Quantity = 10 };
            db.IntakeItems.AddRange(item1, item2);
            await db.SaveChangesAsync();

            DateTime start = new DateTime(2026, 6, 1);
            DateTime end = new DateTime(2026, 6, 30, 23, 59, 59);

            var filtered = await db.IntakeItems.Where(dt => dt.SupplierId == sup.Id && dt.SuppliedDate >= start && dt.SuppliedDate <= end).ToListAsync();
            Assert.Equal(1, filtered.Count);
            Assert.Equal(new DateTime(2026, 6, 20), filtered[0].SuppliedDate);
        }

        [TestCase("TC-MOD4-004", "Supplier", "ManageSupplier Stock Modification Sync", "Integration")]
        public async Task Test_ManageSupplier_StockModificationSync()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Cricket" };
            var eq = new Equipment { Name = "Cricket Bat", Quantity = 10, BrokenQty = 2, Category = cat };
            var sup = new Supplier { Name = "SG Sports", PhoneNumber = "0119998888" };
            var intake = new IntakeItem { Equipment = eq, Supplier = sup, SuppliedDate = DateTime.Now, Quantity = 10, BrokenQty = 2 };

            db.Categories.Add(cat);
            db.Equipments.Add(eq);
            db.Suppliers.Add(sup);
            db.IntakeItems.Add(intake);
            await db.SaveChangesAsync();

            int oldTotalQty = intake.Quantity;
            int oldBrokenQty = intake.BrokenQty;
            int oldHealthyQty = oldTotalQty - oldBrokenQty; // 8

            int newHealthyQty = 12;
            int newBrokenQty = 3;
            int newTotalQty = newHealthyQty + newBrokenQty; // 15

            int healthyChange = newHealthyQty - oldHealthyQty; // +4
            int brokenChange = newBrokenQty - oldBrokenQty;   // +1

            eq.Quantity += healthyChange;
            eq.BrokenQty += brokenChange;
            intake.Quantity = newTotalQty;
            intake.BrokenQty = newBrokenQty;

            await db.SaveChangesAsync();

            var updatedEq = await db.Equipments.FindAsync(eq.Id);
            var updatedIntake = await db.IntakeItems.FindAsync(intake.Id);

            Assert.Equal(14, updatedEq!.Quantity);
            Assert.Equal(3, updatedEq.BrokenQty);
            Assert.Equal(15, updatedIntake!.Quantity);
            Assert.Equal(3, updatedIntake.BrokenQty);
        }

        [TestCase("TC-MOD4-005", "Supplier", "ManageSupplier Delete History with Stock Deduction", "Functional")]
        public async Task Test_ManageSupplier_DeleteWithStockDeduction()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Football" };
            var eq = new Equipment { Name = "Shin Guards", Quantity = 15, BrokenQty = 3, Category = cat };
            var sup = new Supplier { Name = "Nike SL", PhoneNumber = "0114445555" };
            var intake = new IntakeItem { Equipment = eq, Supplier = sup, SuppliedDate = DateTime.Now, Quantity = 5, BrokenQty = 1 };

            db.Categories.Add(cat);
            db.Equipments.Add(eq);
            db.Suppliers.Add(sup);
            db.IntakeItems.Add(intake);
            await db.SaveChangesAsync();

            db.IntakeItems.Remove(intake);
            int brokenQty = intake.BrokenQty;
            int healthyQty = intake.Quantity - brokenQty;
            if (healthyQty < 0) healthyQty = 0;

            eq.Quantity = Math.Max(0, eq.Quantity - healthyQty);
            eq.BrokenQty = Math.Max(0, eq.BrokenQty - brokenQty);
            await db.SaveChangesAsync();

            var remainingIntake = await db.IntakeItems.FindAsync(intake.Id);
            var remainingEq = await db.Equipments.FindAsync(eq.Id);

            Assert.Null(remainingIntake);
            Assert.Equal(11, remainingEq!.Quantity);
            Assert.Equal(2, remainingEq.BrokenQty);
        }

        [TestCase("TC-MOD4-006", "Supplier", "ManageSupplier Delete History without Stock Deduction", "Functional")]
        public async Task Test_ManageSupplier_DeleteWithoutStockDeduction()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Football" };
            var eq = new Equipment { Name = "Keeper Gloves", Quantity = 8, BrokenQty = 1, Category = cat };
            var sup = new Supplier { Name = "Puma SL", PhoneNumber = "0114445555" };
            var intake = new IntakeItem { Equipment = eq, Supplier = sup, SuppliedDate = DateTime.Now, Quantity = 4, BrokenQty = 1 };

            db.Categories.Add(cat);
            db.Equipments.Add(eq);
            db.Suppliers.Add(sup);
            db.IntakeItems.Add(intake);
            await db.SaveChangesAsync();

            db.IntakeItems.Remove(intake);
            await db.SaveChangesAsync();

            var remainingIntake = await db.IntakeItems.FindAsync(intake.Id);
            var remainingEq = await db.Equipments.FindAsync(eq.Id);

            Assert.Null(remainingIntake);
            Assert.Equal(8, remainingEq!.Quantity);
            Assert.Equal(1, remainingEq.BrokenQty);
        }
    }
}
