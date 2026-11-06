using System;
using Project_Sport_Room.Models;

namespace Project_Sport_Room.TestRunner.Modules
{
    public class DomainModelTests
    {
        [TestCase("TC-MOD7-001", "Domain Model", "BorrowReceipt UpdateStatus: Active Loan", "Unit")]
        public void Test_Receipt_Status_ActiveBorrowed()
        {
            var receipt = new BorrowReceipt
            {
                IssuedDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7),
                ReturnedDate = null
            };
            receipt.UpdateStatus();

            Assert.Equal("Borrowed", receipt.Status);
        }

        [TestCase("TC-MOD7-002", "Domain Model", "BorrowReceipt UpdateStatus: Overdue Loan", "Unit")]
        public void Test_Receipt_Status_Overdue()
        {
            var receipt = new BorrowReceipt
            {
                IssuedDate = DateTime.Now.AddDays(-10),
                DueDate = DateTime.Now.AddDays(-2),
                ReturnedDate = null
            };
            receipt.UpdateStatus();

            Assert.Equal("Overdue", receipt.Status);
        }

        [TestCase("TC-MOD7-003", "Domain Model", "BorrowReceipt UpdateStatus: On-Time Return", "Unit")]
        public void Test_Receipt_Status_ReturnedOnTime()
        {
            var due = DateTime.Now.AddDays(5);
            var receipt = new BorrowReceipt
            {
                IssuedDate = DateTime.Now.AddDays(-2),
                DueDate = due,
                ReturnedDate = due.AddHours(-2) // 2 hours before due
            };
            receipt.UpdateStatus();

            Assert.Equal("Returned", receipt.Status);
        }

        [TestCase("TC-MOD7-004", "Domain Model", "BorrowReceipt UpdateStatus: Late Return", "Unit")]
        public void Test_Receipt_Status_ReturnedLate()
        {
            var due = DateTime.Now.AddDays(-3);
            var receipt = new BorrowReceipt
            {
                IssuedDate = DateTime.Now.AddDays(-10),
                DueDate = due,
                ReturnedDate = DateTime.Now // Returned today, 3 days after due
            };
            receipt.UpdateStatus();

            Assert.Equal("Returned Late", receipt.Status);
        }
    }
}

