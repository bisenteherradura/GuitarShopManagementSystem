using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarShopManagementSystem.Context.DbModel;
using Microsoft.EntityFrameworkCore;
namespace GuitarShopManagementSystem.Context
{
    public class GuitarShopManagementSystemDBContext : DbContext
    {
        public DbSet<InventoryTable> inventoryTable {  get; set; }
        public DbSet<CustomerTable> customerTable { get; set; }
        public DbSet<UserTable> userTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8VJ97H3;Database=GuitarShopManagementSystem;Trusted_Connection=True;TrustServerCertificate=True; Encrypt=false;");
        }
    }
}
