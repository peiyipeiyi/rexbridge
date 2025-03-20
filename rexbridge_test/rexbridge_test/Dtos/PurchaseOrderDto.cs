/* Date     : 20/03/2025
 * Author   : Soh Pei Yi
 * Purpose  : 
 * Revision :
 * -------------------------------------------------------------------------------------------------------------------------------------------------
 * |No      |Date           |Author                     |Description
 * -------------------------------------------------------------------------------------------------------------------------------------------------
 * |1       |               |                           |
 * -------------------------------------------------------------------------------------------------------------------------------------------------
 */

using rexbridge_test.Models;

namespace rexbridge_test.Dtos
{
    public class PurchaseOrderDto
    {
        public int Key { get; set; }

        public string RefNumber { get; set; } = string.Empty;

        public int RetailerKey { get; set; }

        public int SupplierKey { get; set; }

        public int ItemKey { get; set; } 

        public int Quantity { get; set; }

        public decimal Amount { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public DateTime ExpiryDate { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CreatedBy { get; set; } = string.Empty;

        public DateTime EditedAt { get; set; }

        public string EditedBy { get; set; } = string.Empty;

        public byte[] RowVersion { get; set; }

        //public RetailerDetailDto Retailer { get; set; }

        //public SupplierDetailDto Supplier { get; set; }

    }
}
