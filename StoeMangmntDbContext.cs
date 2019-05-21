using Microsoft.EntityFrameworkCore;
using StoreManagement_Customers_Baskets_Products;

namespace StoreManagement_Proj
{
    public class StoreManagementDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Baskets> Baskets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder
                .UseSqlServer(@"Server = DESKTOP-J5BQOU7\MSSQLSERVER01; Database=StoreManagement  Trusted_Connection = True;  ConnectRetryCount = 0;Integrated Security=SSPI;",
                b => b.EnableRetryOnFailure());
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Product>().HasMany(b => b.Baskets);
           modelBuilder.Entity<Baskets>().HasMany(c => c.Products);
            modelBuilder.Entity<Baskets>().HasOne(c => c.Customer);
            modelBuilder.Entity<Customer>().HasMany(b => b.Baskets);
            modelBuilder.Entity<Customer>()
                    .HasIndex(u => u.Email)
                    .IsUnique();

        }


    }
}