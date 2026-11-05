using System;
using System.ComponentModel.DataAnnotations;

namespace Project_Sport_Room.Models
{
    public class BorrowedCombination
    {
        [Key] public string CombinationId { get; set; }

        public string ReceiptId { get; set; }
        public BorrowReceipt BorrowReceipt { get; set; }

        public string EquipmentId { get; set; }
        public Equipment Equipment { get; set; }

        public int Qty { get; set; }

        public int ReturnedQuantity { get; set; }
        public int BrokenQty { get; set; }

        public BorrowedCombination()
        {
            CombinationId = "BCOM_" + Guid.NewGuid().ToString().Substring(0, 5).ToUpper();
        }
    }
}

