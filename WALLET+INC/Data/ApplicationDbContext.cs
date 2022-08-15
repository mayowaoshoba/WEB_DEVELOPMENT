using Microsoft.EntityFrameworkCore;
using WALLET_INC.Data.Configurations;
using WALLET_INC.Data.Entities;

namespace WALLET_INC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        
        public DbSet<Customer>Customers{ get; set; }
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CustomerConfiguration.Build(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
