/* Date     : 20/03/2025
 * Author   : Soh Pei Yi
 * Purpose  : Controller for Purchase Order.
 * Revision :
 * -------------------------------------------------------------------------------------------------------------------------------------------------
 * |No      |Date           |Author                     |Description
 * -------------------------------------------------------------------------------------------------------------------------------------------------
 * |1       |               |                           |
 * -------------------------------------------------------------------------------------------------------------------------------------------------
 */

using Microsoft.AspNetCore.Mvc;
using rexbridge_test.Dtos;
using rexbridge_test.Mappers;
using rexbridge_test.Repository;

namespace rexbridge_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController (PurchaseOrderRepository purchaseOrderRepo) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await purchaseOrderRepo.GetAllAsync());
        }

        [HttpGet("by-order-date")]
        public async Task<IActionResult> GetByOrderDate([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            if (startDate > endDate)
            {
                return BadRequest("Start date cannot be later than end date.");
            }

            var purchaseOrders = await purchaseOrderRepo.GetByOrderDateAsync(startDate, endDate);

            if (purchaseOrders == null || !purchaseOrders.Any())
            {
                return NotFound("No purchase orders found within the given order date range.");
            }

            return Ok(purchaseOrders);
        }

        [HttpGet("by-expiry-date")]
        public async Task<IActionResult> GetByExpiryDate([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            if (startDate > endDate)
            {
                return BadRequest("Start date cannot be later than end date.");
            }

            var purchaseOrders = await purchaseOrderRepo.GetByExpiryDateAsync(startDate, endDate);

            if (purchaseOrders == null || !purchaseOrders.Any())
            {
                return NotFound("No purchase orders found within the given expiry date range.");
            }

            return Ok(purchaseOrders);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePurchaseOrderRequestDto mstPurchaseOrderDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mstPurchaseOrder = mstPurchaseOrderDto.ToPurchaseOrderFromCreate();
            return Ok(await purchaseOrderRepo.CreateAsync(mstPurchaseOrder));
        }

    }
}
