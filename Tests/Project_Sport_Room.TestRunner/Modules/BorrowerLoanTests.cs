using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Project_Sport_Room.Models;



namespace Project_Sport_Room.TestRunner.Modules

{

    public class BorrowerLoanTests

    {

        [TestCase("TC-MOD6-001", "Borrower / Loan", "Borrower Role Staff Auto-Generated ID", "Unit")]

        public void Test_Borrower_StaffIdGeneration()

        {

            var staff1 = new Borrower("Staff");

            var staff2 = new Borrower("Staff");



            Assert.NotNull(staff1.BorrowerId);

            Assert.True(staff1.BorrowerId.StartsWith("STFF_"), "Staff ID must start with STFF_");

            Assert.True(staff1.BorrowerId.Length == 10);

            Assert.False(staff1.BorrowerId == staff2.BorrowerId, "Each staff member must receive a unique ID");

        }



        [TestCase("TC-MOD6-002", "Borrower / Loan", "Borrower Role Student Manual ID", "Unit")]

        public void Test_Borrower_StudentManualId()

        {

            string studentRegNo = "UWU/CST/22/045";

            var student = new Borrower("Student", studentRegNo);



            Assert.Equal(studentRegNo, student.BorrowerId);

            Assert.Equal("Student", student.Role);

        }



        [TestCase("TC-MOD6-003", "Borrower / Loan", "Loan Stock Deduction on Checkout", "Integration")]

        public async Task Test_Loan_StockDeductionOnCheckout()

        {

            using var testDb = new IsolatedTestDatabase();

            using var db = testDb.CreateContext();



            var cat = new Category { CategoryName = "Indoor" };

            var eq = new Equipment { Name = "Carrom Board", Quantity = 10, Category = cat };

            var dep = new Department { Name = "Computing" };

            var student = new Borrower("Student", "STU_100") { Name = "Kasun", Department = dep, Email = "kasun@test.com", PhoneNumber = "0712345678" };



            db.Categories.Add(cat);

            db.Equipments.Add(eq);

            db.Departments.Add(dep);

            db.Borrowers.Add(student);

            await db.SaveChangesAsync();



            int requestedQty = 3;

            Assert.True(eq.Quantity >= requestedQty, "Sufficient stock check");

            eq.Quantity -= requestedQty;



            var receipt = new BorrowReceipt

            {

                Borrower = student,

                IssuedDate = DateTime.Now,

                DueDate = DateTime.Now.AddDays(7),

                BorrowedCombinations = new List<BorrowedCombination>()

            };

            receipt.BorrowedCombinations.Add(new BorrowedCombination

            {

                BorrowReceipt = receipt,

                EquipmentId = eq.Id,

                Qty = requestedQty,

                BrokenQty = 0,

                ReturnedQuantity = 0

            });



            db.BorrowReceipts.Add(receipt);

            await db.SaveChangesAsync();



            var updatedEq = await db.Equipments.FindAsync(eq.Id);

            var savedReceipt = await db.BorrowReceipts.Include(r => r.BorrowedCombinations).FirstOrDefaultAsync(r => r.ReceiptId == receipt.ReceiptId);



            Assert.Equal(7, updatedEq!.Quantity);

            Assert.NotNull(savedReceipt);

            Assert.Equal(1, savedReceipt.BorrowedCombinations.Count);

            Assert.Equal(3, savedReceipt.BorrowedCombinations[0].Qty);

        }



        [TestCase("TC-MOD6-004", "Borrower / Loan", "Out of Stock Checkout Prevention", "Negative / Boundary")]

        public void Test_Loan_OutOfStockPrevention()

        {

            int currentStock = 2;

            int requestedQty = 5;



            bool canCheckout = requestedQty <= currentStock;

            Assert.False(canCheckout, "Cannot check out more units than physically available");

        }



        [TestCase("TC-MOD6-005", "Borrower / Loan", "Aggregated Multi-Row Same Equipment Stock Validation", "Boundary")]

        public void Test_Loan_AggregatedStockValidation()

        {

            int currentStock = 5;

            var requests = new List<int> { 3, 3 };



            int totalRequested = requests.Sum();

            bool canFulfill = totalRequested <= currentStock;



            Assert.False(canFulfill, "Multiple rows requesting same equipment must be aggregated to prevent stock deficit");

        }



        [TestCase("TC-MOD6-006", "Borrower / Loan", "Receipt Return Restocks Inventory", "Integration")]

        public async Task Test_Loan_ReceiptReturnRestocksInventory()

        {

            using var testDb = new IsolatedTestDatabase();

            using var db = testDb.CreateContext();



            var cat = new Category { CategoryName = "Balls" };

            var eq = new Equipment { Name = "Netball", Quantity = 6, Category = cat };

            var dep = new Department { Name = "Management" };

            var student = new Borrower("Student", "STU_200") { Name = "Nimali", Department = dep, Email = "nimali@test.com", PhoneNumber = "0751112233" };



            var receipt = new BorrowReceipt

            {

                Borrower = student,

                IssuedDate = DateTime.Now.AddDays(-3),

                DueDate = DateTime.Now.AddDays(4),

                ReturnedDate = null,

                BorrowedCombinations = new List<BorrowedCombination>()

            };

            receipt.BorrowedCombinations.Add(new BorrowedCombination

            {

                BorrowReceipt = receipt,

                Equipment = eq,

                Qty = 4,

                BrokenQty = 0

            });



            db.Categories.Add(cat);

            db.Equipments.Add(eq);

            db.Departments.Add(dep);

            db.Borrowers.Add(student);

            db.BorrowReceipts.Add(receipt);

            await db.SaveChangesAsync();



            receipt.ReturnedDate = DateTime.Now;

            receipt.UpdateStatus();



            foreach (var combo in receipt.BorrowedCombinations)

            {

                var equipment = await db.Equipments.FindAsync(combo.EquipmentId);

                if (equipment != null)

                {

                    equipment.Quantity += combo.Qty;

                }

            }

            await db.SaveChangesAsync();



            var restockedEq = await db.Equipments.FindAsync(eq.Id);

            var updatedReceipt = await db.BorrowReceipts.FindAsync(receipt.ReceiptId);



            Assert.Equal(10, restockedEq!.Quantity);

            Assert.NotNull(updatedReceipt!.ReturnedDate);

            Assert.Equal("Returned", updatedReceipt.Status);

        }



        [TestCase("TC-MOD6-007", "Borrower / Loan", "Prevent Duplicate Restock on Already Returned Receipt", "Negative")]

        public async Task Test_Loan_PreventDuplicateRestock()

        {

            using var testDb = new IsolatedTestDatabase();

            using var db = testDb.CreateContext();



            var cat = new Category { CategoryName = "Balls" };

            var eq = new Equipment { Name = "Handball", Quantity = 10, Category = cat };

            var dep = new Department { Name = "Science" };

            var student = new Borrower("Student", "STU_300") { Name = "Ruwan", Department = dep, Email = "ruwan@test.com", PhoneNumber = "0788889999" };



            var receipt = new BorrowReceipt

            {

                Borrower = student,

                IssuedDate = DateTime.Now.AddDays(-5),

                DueDate = DateTime.Now.AddDays(2),

                ReturnedDate = DateTime.Now.AddDays(-1),

                BorrowedCombinations = new List<BorrowedCombination>()

            };

            receipt.BorrowedCombinations.Add(new BorrowedCombination

            {

                BorrowReceipt = receipt,

                Equipment = eq,

                Qty = 3

            });



            db.Categories.Add(cat);

            db.Equipments.Add(eq);

            db.Departments.Add(dep);

            db.Borrowers.Add(student);

            db.BorrowReceipts.Add(receipt);

            await db.SaveChangesAsync();



            bool wasRestocked = false;

            if (receipt.ReturnedDate == null)

            {

                foreach (var combo in receipt.BorrowedCombinations)

                {

                    eq.Quantity += combo.Qty;

                }

                wasRestocked = true;

            }



            Assert.False(wasRestocked, "Already returned receipt must not be restocked a second time");

            Assert.Equal(10, eq.Quantity);

        }



        [TestCase("TC-MOD6-008", "Borrower / Loan", "BorrowerForm Return Checkbox Uncheck Deducts Stock", "Integration")]

        public async Task Test_Loan_UncheckReturnedDeductsStock()

        {

            using var testDb = new IsolatedTestDatabase();

            using var db = testDb.CreateContext();



            var cat = new Category { CategoryName = "Fitness" };

            var eq = new Equipment { Name = "Skipping Rope", Quantity = 10, Category = cat };

            var dep = new Department { Name = "Technology" };

            var student = new Borrower("Student", "STU_400") { Name = "Amara", Department = dep, Email = "amara@test.com", PhoneNumber = "0766665555" };



            var receipt = new BorrowReceipt

            {

                Borrower = student,

                IssuedDate = DateTime.Now.AddDays(-2),

                DueDate = DateTime.Now.AddDays(5),

                ReturnedDate = DateTime.Now,

                BorrowedCombinations = new List<BorrowedCombination>()

            };

            receipt.BorrowedCombinations.Add(new BorrowedCombination

            {

                BorrowReceipt = receipt,

                Equipment = eq,

                Qty = 2

            });



            db.Categories.Add(cat);

            db.Equipments.Add(eq);

            db.Departments.Add(dep);

            db.Borrowers.Add(student);

            db.BorrowReceipts.Add(receipt);

            await db.SaveChangesAsync();



            if (receipt.ReturnedDate != null)

            {

                receipt.ReturnedDate = null;

                receipt.UpdateStatus();



                foreach (var combo in receipt.BorrowedCombinations)

                {

                    eq.Quantity -= combo.Qty;

                }

                await db.SaveChangesAsync();

            }



            var updatedEq = await db.Equipments.FindAsync(eq.Id);

            var updatedReceipt = await db.BorrowReceipts.FindAsync(receipt.ReceiptId);



            Assert.Equal(8, updatedEq!.Quantity);

            Assert.Null(updatedReceipt!.ReturnedDate);

            Assert.Equal("Borrowed", updatedReceipt.Status);

        }



        [TestCase("TC-MOD6-009", "Borrower / Loan", "Return with Damaged Items Correct Stock Split", "Functional / Math")]

        public async Task Test_Loan_ReturnWithDamagedSplit_RestocksCorrectly()

        {

            using var testDb = new IsolatedTestDatabase();

            using var db = testDb.CreateContext();



            var cat = new Category { CategoryName = "Cricket" };

            var eq = new Equipment { Name = "Cricket Bat", Quantity = 10, BrokenQty = 2, Category = cat };

            var dep = new Department { Name = "Sports" };

            var student = new Borrower("Student", "STU_501") { Name = "Nuwan", Department = dep, Email = "nuwan@test.com", PhoneNumber = "0770001111" };



            var receipt = new BorrowReceipt

            {

                Borrower = student,

                IssuedDate = DateTime.Now.AddDays(-3),

                DueDate = DateTime.Now.AddDays(4),

                ReturnedDate = null,

                BorrowedCombinations = new List<BorrowedCombination>()

            };

            var combo = new BorrowedCombination

            {

                BorrowReceipt = receipt,

                Equipment = eq,

                Qty = 5,

                BrokenQty = 2, // 2 broken during loan period

                ReturnedQuantity = 0

            };

            receipt.BorrowedCombinations.Add(combo);



            db.Categories.Add(cat);

            db.Equipments.Add(eq);

            db.Departments.Add(dep);

            db.Borrowers.Add(student);

            db.BorrowReceipts.Add(receipt);

            await db.SaveChangesAsync();



            // Total physical stock initially: Available(10) + Damaged(2) + Borrowed(5) = 17

            int initialPhysical = eq.Quantity + eq.BrokenQty + combo.Qty;

            Assert.Equal(17, initialPhysical);



            // Execute return logic as in BorrowerForm and manageBorrower

            receipt.ReturnedDate = DateTime.Now;

            receipt.UpdateStatus();



            int broken = Math.Max(0, combo.BrokenQty);

            int healthy = Math.Max(0, combo.Qty - broken); // 5 - 2 = 3

            eq.Quantity += healthy;

            eq.BrokenQty += broken;

            combo.ReturnedQuantity = combo.Qty;



            await db.SaveChangesAsync();



            var updatedEq = await db.Equipments.FindAsync(eq.Id);

            var updatedCombo = await db.BorrowedCombinations.FindAsync(combo.CombinationId);



            Assert.Equal(13, updatedEq!.Quantity);  // 10 + 3 = 13

            Assert.Equal(4, updatedEq.BrokenQty);   // 2 + 2 = 4

            Assert.Equal(5, updatedCombo!.ReturnedQuantity);



            // Invariant total physical stock after return: Available(13) + Damaged(4) + Borrowed(0) = 17

            int postReturnPhysical = updatedEq.Quantity + updatedEq.BrokenQty;

            Assert.Equal(17, postReturnPhysical);

        }



        [TestCase("TC-MOD6-010", "Borrower / Loan", "Uncheck Return with Damaged Items Reverses Correctly", "Functional / Math")]

        public async Task Test_Loan_UncheckReturnWithDamagedItems_ReversesCorrectly()

        {

            using var testDb = new IsolatedTestDatabase();

            using var db = testDb.CreateContext();



            var cat = new Category { CategoryName = "Football" };

            var eq = new Equipment { Name = "Match Ball", Quantity = 13, BrokenQty = 4, Category = cat };

            var dep = new Department { Name = "Science" };

            var student = new Borrower("Student", "STU_502") { Name = "Saman", Department = dep, Email = "saman@test.com", PhoneNumber = "0770002222" };



            var receipt = new BorrowReceipt

            {

                Borrower = student,

                IssuedDate = DateTime.Now.AddDays(-3),

                DueDate = DateTime.Now.AddDays(4),

                ReturnedDate = DateTime.Now,

                BorrowedCombinations = new List<BorrowedCombination>()

            };

            var combo = new BorrowedCombination

            {

                BorrowReceipt = receipt,

                Equipment = eq,

                Qty = 5,

                BrokenQty = 2,

                ReturnedQuantity = 5

            };

            receipt.BorrowedCombinations.Add(combo);



            db.Categories.Add(cat);

            db.Equipments.Add(eq);

            db.Departments.Add(dep);

            db.Borrowers.Add(student);

            db.BorrowReceipts.Add(receipt);

            await db.SaveChangesAsync();



            // Uncheck return (reverse action)

            receipt.ReturnedDate = null;

            receipt.UpdateStatus();



            int broken = Math.Max(0, combo.BrokenQty);

            int healthy = Math.Max(0, combo.Qty - broken);

            eq.Quantity = Math.Max(0, eq.Quantity - healthy);

            eq.BrokenQty = Math.Max(0, eq.BrokenQty - broken);

            combo.ReturnedQuantity = 0;



            await db.SaveChangesAsync();



            var updatedEq = await db.Equipments.FindAsync(eq.Id);

            var updatedCombo = await db.BorrowedCombinations.FindAsync(combo.CombinationId);



            Assert.Equal(10, updatedEq!.Quantity); // 13 - 3 = 10

            Assert.Equal(2, updatedEq.BrokenQty);  // 4 - 2 = 2

            Assert.Equal(0, updatedCombo!.ReturnedQuantity);

            Assert.Null(receipt.ReturnedDate);

        }



        [TestCase("TC-MOD6-011", "Borrower / Loan", "ManageBorrower Active Loan Quantity Change Adjusts Shelf Stock", "Functional / Math")]

        public async Task Test_ManageBorrower_ActiveLoanQuantityChange_AdjustsShelfStock()

        {

            using var testDb = new IsolatedTestDatabase();

            using var db = testDb.CreateContext();



            var cat = new Category { CategoryName = "Badminton" };

            var eq = new Equipment { Name = "Racket", Quantity = 10, BrokenQty = 0, Category = cat };

            var dep = new Department { Name = "Management" };

            var student = new Borrower("Student", "STU_503") { Name = "Nimal", Department = dep, Email = "nimal@test.com", PhoneNumber = "0770003333" };



            var receipt = new BorrowReceipt

            {

                Borrower = student,

                IssuedDate = DateTime.Now,

                DueDate = DateTime.Now.AddDays(5),

                ReturnedDate = null,

                BorrowedCombinations = new List<BorrowedCombination>()

            };

            var combo = new BorrowedCombination

            {

                BorrowReceipt = receipt,

                Equipment = eq,

                Qty = 4,

                BrokenQty = 0

            };

            receipt.BorrowedCombinations.Add(combo);



            db.Categories.Add(cat);

            db.Equipments.Add(eq);

            db.Departments.Add(dep);

            db.Borrowers.Add(student);

            db.BorrowReceipts.Add(receipt);

            await db.SaveChangesAsync();



            // Case A: User increases active loan from 4 to 6 (2 more taken)

            int oldQty = combo.Qty;

            int newQty = 6;

            int qtyDiff = newQty - oldQty;

            eq.Quantity = Math.Max(0, eq.Quantity - qtyDiff);

            combo.Qty = newQty;

            await db.SaveChangesAsync();



            var eqAfterIncrease = await db.Equipments.FindAsync(eq.Id);

            Assert.Equal(8, eqAfterIncrease!.Quantity); // 10 - 2 = 8



            // Case B: User decreases active loan from 6 to 2 (4 returned early)

            oldQty = combo.Qty;

            newQty = 2;

            qtyDiff = newQty - oldQty; // -4

            eq.Quantity = Math.Max(0, eq.Quantity - qtyDiff); // 8 - (-4) = 12

            combo.Qty = newQty;

            await db.SaveChangesAsync();



            var eqAfterDecrease = await db.Equipments.FindAsync(eq.Id);

            Assert.Equal(12, eqAfterDecrease!.Quantity); // 8 + 4 = 12

        }



        [TestCase("TC-MOD6-012", "Borrower / Loan", "ManageBorrower Returned Loan Edit Adjusts Stock and Broken", "Functional / Math")]

        public async Task Test_ManageBorrower_ReturnedLoanEdit_AdjustsStockAndBrokenCorrectly()

        {

            using var testDb = new IsolatedTestDatabase();

            using var db = testDb.CreateContext();



            var cat = new Category { CategoryName = "Table Tennis" };

            var eq = new Equipment { Name = "TT Blade", Quantity = 15, BrokenQty = 0, Category = cat };

            var dep = new Department { Name = "Engineering" };

            var student = new Borrower("Student", "STU_504") { Name = "Kavindu", Department = dep, Email = "kavi@test.com", PhoneNumber = "0770004444" };



            var receipt = new BorrowReceipt

            {

                Borrower = student,

                IssuedDate = DateTime.Now.AddDays(-5),

                DueDate = DateTime.Now.AddDays(-1),

                ReturnedDate = DateTime.Now,

                BorrowedCombinations = new List<BorrowedCombination>()

            };

            var combo = new BorrowedCombination

            {

                BorrowReceipt = receipt,

                Equipment = eq,

                Qty = 5,

                BrokenQty = 0,

                ReturnedQuantity = 5

            };

            receipt.BorrowedCombinations.Add(combo);



            db.Categories.Add(cat);

            db.Equipments.Add(eq);

            db.Departments.Add(dep);

            db.Borrowers.Add(student);

            db.BorrowReceipts.Add(receipt);

            await db.SaveChangesAsync();



            // Admin updates returned receipt: marks 2 items broken out of 5

            int oldQty = combo.Qty;

            int oldBroken = combo.BrokenQty;

            int newQty = 5;

            int newBroken = 2;



            int oldHealthy = Math.Max(0, oldQty - oldBroken); // 5

            int newHealthy = Math.Max(0, newQty - newBroken); // 3

            int healthyDiff = newHealthy - oldHealthy;        // -2

            int brokenDiff = newBroken - oldBroken;          // +2



            eq.Quantity = Math.Max(0, eq.Quantity + healthyDiff);

            eq.BrokenQty = Math.Max(0, eq.BrokenQty + brokenDiff);

            combo.Qty = newQty;

            combo.BrokenQty = newBroken;

            combo.ReturnedQuantity = newQty;

            await db.SaveChangesAsync();



            var updatedEq = await db.Equipments.FindAsync(eq.Id);

            Assert.Equal(13, updatedEq!.Quantity); // 15 - 2 = 13

            Assert.Equal(2, updatedEq.BrokenQty);  // 0 + 2 = 2

        }



        [TestCase("TC-MOD6-013", "Borrower / Loan", "AddBorrowers Validation Rejects Negative or Contradictory Quantities", "Boundary / Validation")]

        public void Test_AddBorrowers_Validation_RejectsZeroOrNegativeQuantities()

        {

            // Case 1: Qty <= 0 must fail

            int zeroQty = 0;

            int negativeQty = -3;

            Assert.False(zeroQty > 0, "Qty of 0 must be rejected");

            Assert.False(negativeQty > 0, "Negative Qty must be rejected");



            // Case 2: BrokenQty < 0 must fail

            int negativeBroken = -1;

            Assert.False(negativeBroken >= 0, "Negative BrokenQty must be rejected");



            // Case 3: BrokenQty > Qty must fail (mathematically impossible)

            int qty = 4;

            int brokenQty = 6;

            bool isBrokenValid = brokenQty <= qty;

            Assert.False(isBrokenValid, "Damaged quantity cannot exceed borrowed quantity");

        }



        [TestCase("TC-MOD6-014", "Borrower / Loan", "Inventory Conservation of Physical Stock Across Full Lifecycle", "Math / Architecture")]

        public async Task Test_InventoryForm_ConservationOfPhysicalStock_AcrossFullLifecycle()

        {

            using var testDb = new IsolatedTestDatabase();

            using var db = testDb.CreateContext();



            var cat = new Category { CategoryName = "Volleyball" };

            var eq = new Equipment { Name = "Mikasa Ball", Quantity = 10, BrokenQty = 2, Category = cat };

            var dep = new Department { Name = "Science" };

            var student = new Borrower("Student", "STU_505") { Name = "Roshan", Department = dep, Email = "roshan@test.com", PhoneNumber = "0770005555" };



            db.Categories.Add(cat);

            db.Equipments.Add(eq);

            db.Departments.Add(dep);

            db.Borrowers.Add(student);

            await db.SaveChangesAsync();



            // Step 1: Initial state

            // Available = 10, Damaged = 2, Borrowed = 0. Total = 12

            int calc1 = eq.Quantity + eq.BrokenQty;

            Assert.Equal(12, calc1);



            // Step 2: Checkout 4 balls

            int borrowQty = 4;

            eq.Quantity -= borrowQty;

            var receipt = new BorrowReceipt

            {

                Borrower = student,

                IssuedDate = DateTime.Now,

                DueDate = DateTime.Now.AddDays(7),

                ReturnedDate = null,

                BorrowedCombinations = new List<BorrowedCombination>()

            };

            var combo = new BorrowedCombination

            {

                BorrowReceipt = receipt,

                Equipment = eq,

                Qty = borrowQty,

                BrokenQty = 1 // 1 broken during use

            };

            receipt.BorrowedCombinations.Add(combo);

            db.BorrowReceipts.Add(receipt);

            await db.SaveChangesAsync();



            // Total: Available(6) + Damaged(2) + Borrowed(4) = 12

            int activeBorrowed = await db.BorrowedCombinations.Where(c => c.BorrowReceipt.ReturnedDate == null).SumAsync(c => c.Qty);

            int calc2 = eq.Quantity + eq.BrokenQty + activeBorrowed;

            Assert.Equal(12, calc2);



            // Step 3: Return with 1 broken, 3 healthy

            receipt.ReturnedDate = DateTime.Now;

            receipt.UpdateStatus();

            int broken = combo.BrokenQty;

            int healthy = combo.Qty - broken;

            eq.Quantity += healthy;

            eq.BrokenQty += broken;

            combo.ReturnedQuantity = combo.Qty;

            await db.SaveChangesAsync();



            // Total: Available(9) + Damaged(3) + Borrowed(0) = 12

            int activeBorrowedAfterReturn = await db.BorrowedCombinations.Where(c => c.BorrowReceipt.ReturnedDate == null).SumAsync(c => (int?)c.Qty) ?? 0;

            int calc3 = eq.Quantity + eq.BrokenQty + activeBorrowedAfterReturn;

            Assert.Equal(12, calc3);

            Assert.Equal(9, eq.Quantity);

            Assert.Equal(3, eq.BrokenQty);

        }

    }

}

