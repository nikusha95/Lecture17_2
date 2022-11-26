using EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(200);
        
        builder.Property(x=>x.LastName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.PersonalId)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.ShippingAddress)
            .IsRequired()
            .HasMaxLength(400);

        builder.Property(x => x.ZipCode)
            .IsRequired()
            .HasMaxLength(10);

        builder.HasMany(x => x.Accounts)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.CustomerId)
            .HasConstraintName("FK_Accounts_Customer");
        
        builder.HasMany(x => x.Orders)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.CustomerId)
            .HasConstraintName("FK_Orders_Customer");
    }
}