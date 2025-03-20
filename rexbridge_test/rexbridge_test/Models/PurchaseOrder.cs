/* Date     : 20/03/2025
 * Author   : Soh Pei Yi
 * Purpose  : Model.
 * Revision :
 * -------------------------------------------------------------------------------------------------------------------------------------------------
 * |No      |Date           |Author                     |Description
 * -------------------------------------------------------------------------------------------------------------------------------------------------
 * |1       |               |                           |
 * -------------------------------------------------------------------------------------------------------------------------------------------------
 */

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rexbridge_test.Models
{
    [Table("tbl_purchase_order", Schema = "dbo")]
    public class PurchaseOrder
    {
        [Column("key", TypeName = "int")]
        [Key]
        public int Key { get; set; }

        [Column("ref_number", TypeName = "varchar(30)")]
        public string RefNumber { get; set; } = string.Empty;

        [Column("retailer_key", TypeName = "int")]
        public int RetailerKey { get; set; }

        public Retailer? Retailer { get; set; }

        [Column("supplier_key", TypeName = "int")]
        public int SupplierKey { get; set; }
        public Supplier? Supplier { get; set; }

        [Column("item_key", TypeName = "int")]
        public int ItemKey { get; set; }
        public Item? Item { get; set; }

        [Column("quantity", TypeName = "int")]
        public int Quantity { get; set; }

        [Column("amount", TypeName = "decimal(18,4)")]
        public decimal Amount { get; set; }

        [Column("order_date", TypeName = "datetime")]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Column("expiry_date", TypeName = "datetime")]
        public DateTime ExpiryDate { get; set; } = DateTime.Now;

        [Column("is_deleted", TypeName = "bit")]
        public bool IsDeleted { get; set; }

        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column("created_by", TypeName = "varchar(100)")]
        public string CreatedBy { get; set; } = string.Empty;

        [Column("edited_at", TypeName = "datetime")]
        public DateTime EditedAt { get; set; } = DateTime.Now;

        [Column("edited_by", TypeName = "varchar(100)")]
        public string EditedBy { get; set; } = string.Empty;

        [Column("row_version", TypeName = "rowversion")]
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public ICollection<Supplier> Suppliers { get; set; }

        public ICollection<Retailer> Retailers { get; set; }

        public ICollection<Retailer> Items { get; set; }
    }
}
