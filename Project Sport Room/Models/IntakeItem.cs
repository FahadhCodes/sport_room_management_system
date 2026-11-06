using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Sport_Room.Models
{
    public class IntakeItem
    {
        [Key]
        public string Id { get; set; }
        public DateTime SuppliedDate { get; set; }
        public int Quantity { get; set; }
        public int BrokenQty { get; set; }

        [ForeignKey(nameof(Equipment))]
        public string EquipmentId { get; set; }
        public Equipment Equipment { get; set; }

        // Foreign Key to Supplier (nullable for legacy/unassigned records)
        [ForeignKey(nameof(Supplier))]
        public string? SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

        public IntakeItem()
        {
            Id = "INTK_" + Guid.NewGuid().ToString().Substring(0, 5).ToUpper();
        }
    }
}
