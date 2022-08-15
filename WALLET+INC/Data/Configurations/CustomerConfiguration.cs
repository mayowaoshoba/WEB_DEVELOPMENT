using Microsoft.EntityFrameworkCore;
using WALLET_INC.Data.Entities;

namespace WALLET_INC.Data.Configurations
{
    public static class CustomerConfiguration
    {
        public static ModelBuilder Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(c => c.FirstName).IsRequired(true).HasMaxLength(100).HasColumnName("first_name");
            modelBuilder.Entity<Customer>().Property(c => c.LastName).IsRequired(true).HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(c => c.MiddleName).IsRequired(true).HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(c => c.Country).HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(c => c.State).HasMaxLength(20);
            modelBuilder.Entity<Customer>().Property(c => c.City).HasMaxLength(20);

            return modelBuilder;
        }
    }
}

