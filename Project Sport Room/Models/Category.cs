using System;
using System.Collections.Generic;

namespace Project_Sport_Room.Models
{
    public class Category
    {
        public string Id { get; set; }
        public string CategoryName { get; set; }

        // Navigation property [allows EF Core to automatically load related items]
        public List<Equipment> Equipments { get; set; }

        public Category()
        {
            // Auto-generates a unique 5-character string appended to your pattern
            Id = "CTGR_" + Guid.NewGuid().ToString().Substring(0, 5).ToUpper();
        }
    }
}

