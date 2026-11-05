using System;

namespace Project_Sport_Room.Models
{
    public class Equipment
    {
        public string Id { get; set; }
        public string Name { get; set; }

        // Add these two properties
        public int Quantity { get; set; }
        public int BrokenQty { get; set; }

        public string CategoryId { get; set; }
        public Category Category { get; set; }

        public Equipment()
        {
            Id = "EQP_" + Guid.NewGuid().ToString().Substring(0, 5).ToUpper();
        }
    }
}

