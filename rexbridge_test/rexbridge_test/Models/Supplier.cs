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
    [Table("tbl_supplier", Schema = "dbo")]
    public class Supplier
    {
        [Column("key", TypeName = "int")]
        [Key]
        public int Key { get; set; }

        [Column("name", TypeName = "varchar(500)")]
        public string Name { get; set; } = string.Empty;

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

        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}