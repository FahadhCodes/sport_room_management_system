using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Sport_Room.Models
{
    public class Borrower
    {
        [Key] public string BorrowerId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; } // "Student" or "Staff"
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DepartmentId { get; set; }
        public Department Department { get; set; }
        
        public List<BorrowReceipt> BorrowReceipts { get; set; }

        // Parameterless constructor required by EF Core
        public Borrower() { }

        /// <summary>
        /// Creates a new Borrower with the given role.
        /// - "Student": BorrowerId must be entered manually (e.g. student registration number).
        /// - "Staff": BorrowerId is auto-generated.
        /// </summary>
        public Borrower(string role, string studentId = null)
        {
            Role = role;

            if (role == "Staff")
            {
                // Auto-generate ID for staff
                GenerateStaffId();
            }
            else if (role == "Student")
            {
                // Student ID is entered manually (e.g. registration number)
                BorrowerId = studentId;
            }
        }

        // Auto-generates a unique ID for Staff members
        public void GenerateStaffId()
        {
            BorrowerId = "STFF_" + Guid.NewGuid().ToString().Substring(0, 5).ToUpper();
        }
    }
}
