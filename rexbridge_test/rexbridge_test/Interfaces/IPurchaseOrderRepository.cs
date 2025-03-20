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

using rexbridge_test.Models;

namespace rexbridge_test.Interfaces
{
    public interface IPurchaseOrderRepository
    {
        Task<List<PurchaseOrder>> GetAllAsync();

        Task<ApiResponse> CreateAsync(PurchaseOrder purchaseOrderModel);

        Task<List<PurchaseOrder>> GetByOrderDateAsync(DateTime startDate, DateTime endDate);

        Task<List<PurchaseOrder>> GetByExpiryDateAsync(DateTime startDate, DateTime endDate);
    }
}
