using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Sport_Room.Models
{
    public class BorrowReceipt
    {
        [Key] public string ReceiptId { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnedDate { get; set; } // The ? makes this optional (nullable)

        public string Status { get; set; }

        public string BorrowerId { get; set; }
        public Borrower Borrower { get; set; }

        public List<BorrowedCombination> BorrowedCombinations { get; set; }

        public BorrowReceipt()
        {
            ReceiptId = "BRCPT_" + Guid.NewGuid().ToString().Substring(0, 5).ToUpper();
            UpdateStatus();
        }

        /// <summary>
        /// Automatically determines the Status based on the dates.
        /// Call this method whenever IssuedDate, DueDate, or ReturnedDate changes.
        /// </summary>
        public void UpdateStatus()
        {
            if (ReturnedDate.HasValue)
            {
                // Item has been returned
                if (ReturnedDate.Value <= DueDate)
                    Status = "Returned";
                else
                    Status = "Returned Late";
            }
            else
            {
                // Item has NOT been returned yet
                if (DateTime.Now > DueDate)
                    Status = "Overdue";
                else
                    Status = "Borrowed";
            }
        }
    }
}
