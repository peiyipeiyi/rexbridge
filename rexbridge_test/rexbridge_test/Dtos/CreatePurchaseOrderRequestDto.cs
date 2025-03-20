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

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rexbridge_test.Dtos
{
    public class CreatePurchaseOrderRequestDto
    {
        [Required]
        public string RefNumber { get; set; } = string.Empty;

        [Required]
        public int RetailerKey { get; set; }

        [Required]
        public int SupplierKey { get; set; }

        [Required]
        public int ItemKey { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        //[Required]
        //public DateTime ExpiryDate { get; set; } = DateTime.Now;

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public string CreatedBy { get; set; } = string.Empty;

    }
}
