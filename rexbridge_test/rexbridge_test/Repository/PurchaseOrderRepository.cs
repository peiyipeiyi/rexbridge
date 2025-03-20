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

using Microsoft.EntityFrameworkCore;
using rexbridge_test.Commons.Messages;
using rexbridge_test.Data;
using rexbridge_test.Interfaces;
using rexbridge_test.Models;

namespace rexbridge_test.Repository
{
    public class PurchaseOrderRepository(DBContext dBContext) : IPurchaseOrderRepository
    {
        public async Task<List<PurchaseOrder>> GetAllAsync()
        {
            var purchaseOrders = dBContext.PurchaseOrders//.Include(u => u.Retailer)
                                                         //.Include(u => u.Supplier)
                                                         .AsQueryable();

            return await purchaseOrders.ToListAsync();
        }

        public async Task<ApiResponse> CreateAsync(PurchaseOrder purchaseOrderModel)
        {
            //Validation for duplicate PO
            var duplicatedMstUser = await dBContext.PurchaseOrders
                .FirstOrDefaultAsync(x => x.RefNumber == purchaseOrderModel.RefNumber && !x.IsDeleted);

            if (duplicatedMstUser != null)
            {
                return new ApiResponse
                {
                    IsSuccess = false,
                    Message = ErrorMessages.DuplicatedDataFound
                };
            }

            await dBContext.PurchaseOrders.AddAsync(purchaseOrderModel);

            await dBContext.SaveChangesAsync();

            return new ApiResponse
            {
                IsSuccess = true,
                Message = SuccessMessages.DataInsertedSuccessfully,
            };
        }

        public async Task<List<PurchaseOrder>> GetByExpiryDateAsync(DateTime startDate, DateTime endDate)
        {
            return await dBContext.PurchaseOrders
                //.Include(u => u.Retailer)
                //.Include(u => u.Supplier)
                .Where(po => po.ExpiryDate >= startDate && po.ExpiryDate <= endDate)
                .ToListAsync();
        }

        public async Task<List<PurchaseOrder>> GetByOrderDateAsync(DateTime startDate, DateTime endDate)
        {
            return await dBContext.PurchaseOrders
                //.Include(u => u.Retailer)
                //.Include(u => u.Supplier)
                .Where(po => po.OrderDate >= startDate && po.OrderDate <= endDate)
                .ToListAsync();
        }
    }
}