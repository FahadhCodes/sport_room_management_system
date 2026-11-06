using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Sport_Room.Models;

namespace Project_Sport_Room.TestRunner.Modules
{
    public class InventoryTests
    {
        [TestCase("TC-MOD2-001", "Inventory", "Equipment Unique Types Count", "Functional")]
        public async Task Test_Equipment_UniqueTypesCount()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Rackets" };
            db.Categories.Add(cat);
            db.Equipments.AddRange(
                new Equipment { Name = "Badminton Racket", Quantity = 10, Category = cat },
                new Equipment { Name = "Tennis Racket", Quantity = 8, Category = cat },
                new Equipment { Name = "Squash Racket", Quantity = 4, Category = cat }
            );
            await db.SaveChangesAsync();

            var totalTypes = await db.Equipments.CountAsync();
            Assert.Equal(3, totalTypes);
        }

        [TestCase("TC-MOD2-002", "Inventory", "Healthy Stock vs Total Stock Aggregation", "Unit / Integration")]
        public async Task Test_HealthyVsTotal_Aggregation()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Balls" };
            var eq = new Equipment { Name = "Volleyball", Quantity = 20, BrokenQty = 4, Category = cat };
            var dep = new Department { Name = "Computing" };
            var borrower = new Borrower("Student", "STU_C1") { Name = "Dave", Department = dep, Email = "d@comp.com", PhoneNumber = "333" };
            var receipt = new BorrowReceipt { Borrower = borrower, IssuedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(3) };
            var combo = new BorrowedCombination { BorrowReceipt = receipt, Equipment = eq, Qty = 5 };

            db.Categories.Add(cat);
            db.Equipments.Add(eq);
            db.Departments.Add(dep);
            db.Borrowers.Add(borrower);
            db.BorrowReceipts.Add(receipt);
            db.BorrowedCombinations.Add(combo);
            await db.SaveChangesAsync();

            int availableHealthy = await db.Equipments.SumAsync(x => (int?)x.Quantity) ?? 0;
            int damaged = await db.Equipments.SumAsync(x => (int?)x.BrokenQty) ?? 0;
            int borrowedHealthy = await db.BorrowedCombinations
                .Where(bc => bc.BorrowReceipt.ReturnedDate == null)
                .SumAsync(bc => (int?)bc.Qty) ?? 0;

            int totalPhysicalStock = availableHealthy + damaged + borrowedHealthy;
            int totalHealthyStock = availableHealthy + borrowedHealthy;

            Assert.Equal(20, availableHealthy);
            Assert.Equal(4, damaged);
            Assert.Equal(5, borrowedHealthy);
            Assert.Equal(29, totalPhysicalStock);
            Assert.Equal(25, totalHealthyStock);
        }

        [TestCase("TC-MOD2-003", "Inventory", "Search Filter by Equipment Name Case-Insensitive", "Functional")]
        public async Task Test_SearchFilter_EquipmentName()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Balls" };
            db.Categories.Add(cat);
            db.Equipments.AddRange(
                new Equipment { Name = "Basketball", Quantity = 5, Category = cat },
                new Equipment { Name = "Cricket Ball", Quantity = 12, Category = cat }
            );
            await db.SaveChangesAsync();

            string searchString = "basket";
            var query = db.Equipments.Where(e => e.Id.Contains(searchString) || e.Name.ToLower().Contains(searchString.ToLower()));
            var results = await query.ToListAsync();

            Assert.Equal(1, results.Count);
            Assert.Equal("Basketball", results[0].Name);
        }

        [TestCase("TC-MOD2-004", "Inventory", "Category Filter with All Categories", "Boundary")]
        public async Task Test_CategoryFilter_AllCategories()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat1 = new Category { CategoryName = "Track" };
            var cat2 = new Category { CategoryName = "Field" };
            db.Categories.AddRange(cat1, cat2);
            db.Equipments.AddRange(
                new Equipment { Name = "Stopwatch", Quantity = 6, Category = cat1 },
                new Equipment { Name = "Shot Put", Quantity = 4, Category = cat2 }
            );
            await db.SaveChangesAsync();

            string searchString = "All Categories";
            var query = db.Equipments.AsQueryable();
            if (searchString != "All Categories")
            {
                query = query.Where(data => data.Category.CategoryName.Contains(searchString));
            }
            var results = await query.ToListAsync();

            Assert.Equal(2, results.Count);
        }
    }
}
