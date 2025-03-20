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

using rexbridge_test.Dtos;
using rexbridge_test.Models;

namespace rexbridge_test.Mappers
{
    public static class PurchaseOrderMappers
    {
        public static PurchaseOrderDto ToPurchaseOrderDto(this PurchaseOrder purchaseOrderModel)
        {
            return new PurchaseOrderDto
            {
                Key = purchaseOrderModel.Key,
                RefNumber = purchaseOrderModel.RefNumber,
                RetailerKey = purchaseOrderModel.RetailerKey,
                SupplierKey = purchaseOrderModel.SupplierKey,
                ItemKey = purchaseOrderModel.ItemKey,
                Quantity = purchaseOrderModel.Quantity,
                Amount = purchaseOrderModel.Amount,
                OrderDate = purchaseOrderModel.OrderDate,
                ExpiryDate = purchaseOrderModel.ExpiryDate,

                IsDeleted = purchaseOrderModel.IsDeleted,
                CreatedAt = purchaseOrderModel.CreatedAt,
                CreatedBy = purchaseOrderModel.CreatedBy,
                EditedAt = purchaseOrderModel.EditedAt,
                EditedBy = purchaseOrderModel.EditedBy,
                RowVersion = purchaseOrderModel.RowVersion,
                //Retailer = purchaseOrderModel.Retailer?.RetailerDetailDto(),
                //Supplier = purchaseOrderModel.Supplier?.SupplierDetailDto(),
            };
        }

        public static PurchaseOrder ToPurchaseOrderFromCreate(this CreatePurchaseOrderRequestDto purchaseOrderDto)
        {
            return new PurchaseOrder
            {
                RefNumber = purchaseOrderDto.RefNumber,
                RetailerKey = purchaseOrderDto.RetailerKey,
                SupplierKey = purchaseOrderDto.SupplierKey,
                ItemKey = purchaseOrderDto.ItemKey,
                Quantity = purchaseOrderDto.Quantity,
                Amount = purchaseOrderDto.Amount,
                OrderDate = purchaseOrderDto.OrderDate,
                ExpiryDate = purchaseOrderDto.OrderDate.AddDays(30),
                IsDeleted = purchaseOrderDto.IsDeleted,
                CreatedAt = purchaseOrderDto.CreatedAt,
                CreatedBy = purchaseOrderDto.CreatedBy
                //Retailer = purchaseOrderDto.Retailer?.RetailerDetailDto(),
                //Supplier = purchaseOrderDto.Supplier?.SupplierDetailDto(),
            };
        }
    }
}
