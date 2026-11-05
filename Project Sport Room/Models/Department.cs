using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Sport_Room.Models
{
    public class Department
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }

        // Link to Borrowers (One Department can have many Borrowers)
        public List<Borrower> Borrowers { get; set; }

        public Department()
        {
            Id = "DEPT_" + Guid.NewGuid().ToString().Substring(0, 5).ToUpper();
        }
    }
}