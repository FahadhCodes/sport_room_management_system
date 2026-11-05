using System;
using System.Collections.Generic;

namespace Project_Sport_Room.Models
{
    public class Supplier
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int TotalSuppliedEquipments { get; set; }

        // Navigation property (One Supplier can have many IntakeItems)
        public List<IntakeItem> IntakeItems { get; set; }

        public Supplier()
        {
            Id = "SUPP_" + Guid.NewGuid().ToString().Substring(0, 5).ToUpper();
        }
    }
}

