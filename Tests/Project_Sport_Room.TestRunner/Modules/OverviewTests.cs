using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Sport_Room.Models;

namespace Project_Sport_Room.TestRunner.Modules
{
    public class OverviewTests
    {
        [TestCase("TC-MOD1-001", "Overview", "Calculate Accurate KPIs with Empty Database", "Boundary")]
        public async Task Test_KPIs_EmptyDatabase()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            int available = await db.Equipments.SumAsync(e => (int?)e.Quantity) ?? 0;
            int damaged = await db.Equipments.SumAsync(e => (int?)e.BrokenQty) ?? 0;
            int borrowed = await db.BorrowedCombinations
                .Where(bc => bc.BorrowReceipt.ReturnedDate == null)
                .SumAsync(bc => (int?)bc.Qty) ?? 0;
            int total = available + damaged + borrowed;

            DateTime thirtyDaysAgo = DateTime.Now.AddDays(-30);
            int newlyArr = await db.IntakeItems
                .Where(i => i.SuppliedDate >= thirtyDaysAgo)
                .SumAsync(i => (int?)i.Quantity) ?? 0;

            Assert.Equal(0, available);
            Assert.Equal(0, damaged);
            Assert.Equal(0, borrowed);
            Assert.Equal(0, total);
            Assert.Equal(0, newlyArr);
        }

        [TestCase("TC-MOD1-002", "Overview", "True Total Stock Formula Validation", "Unit / Integration")]
        public async Task Test_TotalStock_Calculation()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Sports Gear" };
            var eq = new Equipment { Name = "Football", Quantity = 10, BrokenQty = 2, Category = cat };
            var dep = new Department { Name = "Physical Education" };
            var borrower = new Borrower("Student", "STU_001") { Name = "John Doe", Department = dep, Email = "john@test.com", PhoneNumber = "0711111111" };
            var receipt = new BorrowReceipt { Borrower = borrower, IssuedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(7) };
            var combo = new BorrowedCombination { BorrowReceipt = receipt, Equipment = eq, Qty = 3, BrokenQty = 0 };

            db.Categories.Add(cat);
            db.Equipments.Add(eq);
            db.Departments.Add(dep);
            db.Borrowers.Add(borrower);
            db.BorrowReceipts.Add(receipt);
            db.BorrowedCombinations.Add(combo);
            await db.SaveChangesAsync();

            int available = await db.Equipments.SumAsync(e => (int?)e.Quantity) ?? 0;
            int damaged = await db.Equipments.SumAsync(e => (int?)e.BrokenQty) ?? 0;
            int borrowed = await db.BorrowedCombinations
                .Where(bc => bc.BorrowReceipt.ReturnedDate == null)
                .SumAsync(bc => (int?)bc.Qty) ?? 0;

            int total = available + damaged + borrowed;

            Assert.Equal(10, available);
            Assert.Equal(2, damaged);
            Assert.Equal(3, borrowed);
            Assert.Equal(15, total);
        }

        [TestCase("TC-MOD1-003", "Overview", "Newly Arrived Intake Filter (30 Days Boundary)", "Boundary")]
        public async Task Test_NewlyArrived_Boundary()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Athletics" };
            var eq = new Equipment { Name = "Javelin", Quantity = 15, Category = cat };
            var sup = new Supplier { Name = "Olympic Supplies", PhoneNumber = "0112223333" };

            var intakeRecent = new IntakeItem { Equipment = eq, Supplier = sup, SuppliedDate = DateTime.Now.AddDays(-10), Quantity = 10, BrokenQty = 0 };
            var intakeOld = new IntakeItem { Equipment = eq, Supplier = sup, SuppliedDate = DateTime.Now.AddDays(-35), Quantity = 5, BrokenQty = 0 };

            db.Categories.Add(cat);
            db.Equipments.Add(eq);
            db.Suppliers.Add(sup);
            db.IntakeItems.AddRange(intakeRecent, intakeOld);
            await db.SaveChangesAsync();

            DateTime thirtyDaysAgo = DateTime.Now.AddDays(-30);
            int newlyArr = await db.IntakeItems
                .Where(i => i.SuppliedDate >= thirtyDaysAgo)
                .SumAsync(i => (int?)i.Quantity) ?? 0;

            Assert.Equal(10, newlyArr);
        }

        [TestCase("TC-MOD1-004", "Overview", "Multi-Criteria Status Filter: Overdue Detection", "Functional")]
        public async Task Test_StatusFilter_Overdue()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Indoor" };
            var eq = new Equipment { Name = "Chess Board", Quantity = 5, Category = cat };
            var dep = new Department { Name = "Science" };
            var borrower = new Borrower("Student", "STU_002") { Name = "Alice", Department = dep, Email = "alice@test.com", PhoneNumber = "0771234567" };
            var receipt = new BorrowReceipt { Borrower = borrower, IssuedDate = DateTime.Now.AddDays(-10), DueDate = DateTime.Now.AddDays(-2), ReturnedDate = null };
            var combo = new BorrowedCombination { BorrowReceipt = receipt, Equipment = eq, Qty = 1 };

            db.Categories.Add(cat);
            db.Equipments.Add(eq);
            db.Departments.Add(dep);
            db.Borrowers.Add(borrower);
            db.BorrowReceipts.Add(receipt);
            db.BorrowedCombinations.Add(combo);
            await db.SaveChangesAsync();

            DateTime now = DateTime.Now;
            var overdueItems = await db.BorrowedCombinations
                .Where(bc => bc.BorrowReceipt.ReturnedDate == null && bc.BorrowReceipt.DueDate < now)
                .ToListAsync();

            Assert.Equal(1, overdueItems.Count);
        }

        [TestCase("TC-MOD1-005", "Overview", "Multi-Criteria Status Filter: Returned Late Detection", "Functional")]
        public async Task Test_StatusFilter_ReturnedLate()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Indoor" };
            var eq = new Equipment { Name = "Table Tennis Bat", Quantity = 4, Category = cat };
            var dep = new Department { Name = "Arts" };
            var borrower = new Borrower("Staff") { Name = "Dr. Smith", Department = dep, Email = "smith@test.com", PhoneNumber = "0770000000" };
            var receipt = new BorrowReceipt { Borrower = borrower, IssuedDate = DateTime.Now.AddDays(-10), DueDate = DateTime.Now.AddDays(-5), ReturnedDate = DateTime.Now.AddDays(-1) };
            var combo = new BorrowedCombination { BorrowReceipt = receipt, Equipment = eq, Qty = 2 };

            db.Categories.Add(cat);
            db.Equipments.Add(eq);
            db.Departments.Add(dep);
            db.Borrowers.Add(borrower);
            db.BorrowReceipts.Add(receipt);
            db.BorrowedCombinations.Add(combo);
            await db.SaveChangesAsync();

            var returnedLate = await db.BorrowedCombinations
                .Where(bc => bc.BorrowReceipt.ReturnedDate != null && bc.BorrowReceipt.ReturnedDate > bc.BorrowReceipt.DueDate)
                .ToListAsync();

            Assert.Equal(1, returnedLate.Count);
        }

        [TestCase("TC-MOD1-006", "Overview", "Department Filter ALL Handling", "Negative / Functional")]
        public async Task Test_DepartmentFilter_ALL()
        {
            using var testDb = new IsolatedTestDatabase();
            using var db = testDb.CreateContext();

            var cat = new Category { CategoryName = "Track" };
            var eq = new Equipment { Name = "Baton", Quantity = 8, Category = cat };
            var dep1 = new Department { Name = "Engineering" };
            var dep2 = new Department { Name = "Medicine" };
            var b1 = new Borrower("Student", "STU_E1") { Name = "Bob", Department = dep1, Email = "b@eng.com", PhoneNumber = "111" };
            var b2 = new Borrower("Student", "STU_M1") { Name = "Carol", Department = dep2, Email = "c@med.com", PhoneNumber = "222" };
            var r1 = new BorrowReceipt { Borrower = b1, IssuedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(2) };
            var r2 = new BorrowReceipt { Borrower = b2, IssuedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(2) };
            var c1 = new BorrowedCombination { BorrowReceipt = r1, Equipment = eq, Qty = 1 };
            var c2 = new BorrowedCombination { BorrowReceipt = r2, Equipment = eq, Qty = 1 };

            db.Categories.Add(cat);
            db.Equipments.Add(eq);
            db.Departments.AddRange(dep1, dep2);
            db.Borrowers.AddRange(b1, b2);
            db.BorrowReceipts.AddRange(r1, r2);
            db.BorrowedCombinations.AddRange(c1, c2);
            await db.SaveChangesAsync();

            string selectedDept = "ALL";
            var query = db.BorrowedCombinations.AsQueryable();
            if (selectedDept != "ALL")
            {
                query = query.Where(bc => bc.BorrowReceipt.Borrower.DepartmentId == selectedDept);
            }

            var results = await query.ToListAsync();
            Assert.Equal(2, results.Count);
        }
    }
}
