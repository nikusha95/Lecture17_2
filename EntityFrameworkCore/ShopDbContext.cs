using EntityFrameworkCore.Configurations;
using EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore;

public class ShopDbContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<ProductOrder> ProductOrders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=Shop;User Id=sa;Password=Aa123456;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Account>()
        //     .Property(x => x.Balance)
        //     .HasColumnType("decimal(18,2)");
        //
        // modelBuilder.Entity<Account>()
        //     .Property(x => x.Iban)
        //     .HasMaxLength(20);
        modelBuilder.ApplyConfiguration(new AccountConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductTypeConfiguration());
        modelBuilder.ApplyConfiguration(new StatusConfiguration());

        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(AccountConfiguration).Assembly);

    }
}