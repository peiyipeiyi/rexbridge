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

namespace rexbridge_test.Models
{
    /// <summary>
    /// A standard API response structure for this project.
    /// </summary>
    public class ApiResponse
    {
        /// <summary>
        /// Indicates whether the API response was successful?
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Returns message via the API response.
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// Returns data via the API response if necessary.
        /// </summary>
        public dynamic? Data { get; set; }




    }
}
