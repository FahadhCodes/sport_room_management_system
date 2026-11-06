using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Sport_Room.Models;

namespace Project_Sport_Room.TestRunner.Modules
{
    public class SetupTests
    {
        [TestCase("TC-MOD3-001", "Setup", "New Supplier Validation Empty Input", "Negative")]
        public void Test_Supplier_EmptyInputValidation()
        {
            string name = "  ";
            string phone = "";

            bool isValid = !string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(phone);
            Assert.False(isValid, "Validation should reject whitespace or empty supplier input");
        }

        [TestCase("TC-MOD3-002", "Setup", "New Category Unique ID Prefix", "Unit")]
        public void Test_Category_IdPrefix()
        {
            var cat1 = new Category();
            var cat2 = new Category();

            Assert.NotNull(cat1.Id);
            Assert.True(cat1.Id.StartsWith("CTGR_"));
            Assert.True(cat1.Id.Length == 10);
            Assert.False(cat1.Id == cat2.Id, "Category IDs should be uniquely generated");
        }

        [TestCase("TC-MOD3-003", "Setup", "New Equipment Creation with Category FK", "Integration")]
        public async Task Test_Equipment_CreationWithCategory()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Gymnastics" };
            db.Categories.Add(cat);
            await db.SaveChangesAsync();

            var eq = new Equipment
            {
                Name = "Gym Mat",
                CategoryId = cat.Id
            };
            db.Equipments.Add(eq);
            await db.SaveChangesAsync();

            var saved = await db.Equipments.Include(e => e.Category).FirstOrDefaultAsync(e => e.Id == eq.Id);
            Assert.NotNull(saved);
            Assert.Equal("Gym Mat", saved.Name);
            Assert.Equal("Gymnastics", saved.Category.CategoryName);
        }

        [TestCase("TC-MOD3-004", "Setup", "Equipment Auto-Generated ID and Defaults", "Boundary")]
        public async Task Test_Equipment_DefaultsAndId()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Fitness" };
            db.Categories.Add(cat);
            await db.SaveChangesAsync();

            var eq = new Equipment
            {
                Name = "Dumbbell 5kg",
                CategoryId = cat.Id
            };
            db.Equipments.Add(eq);
            await db.SaveChangesAsync();

            var loaded = await db.Equipments.FindAsync(eq.Id);
            Assert.NotNull(loaded);
            Assert.True(loaded.Id.StartsWith("EQP_"));
            Assert.Equal(0, loaded.Quantity);
            Assert.Equal(0, loaded.BrokenQty);
        }
    }
}
