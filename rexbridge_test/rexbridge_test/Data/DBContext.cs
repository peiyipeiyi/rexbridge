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
using rexbridge_test.Models;

namespace rexbridge_test.Data
{
    public class DBContext : DbContext
    {
        public DBContext() { }

        public DBContext(DbContextOptions<DBContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        #region PO

        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }

        public DbSet<Retailer> Retailers { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<PurchaseOrder>()
                   .HasOne(u => u.Supplier)
                   .WithMany(d => d.PurchaseOrders)
                   .HasForeignKey(u => u.SupplierKey);

            builder.Entity<PurchaseOrder>()
                   .HasOne(u => u.Retailer)
                   .WithMany(d => d.PurchaseOrders)
                   .HasForeignKey(u => u.RetailerKey);

            base.OnModelCreating(builder);
        }
    }
}
