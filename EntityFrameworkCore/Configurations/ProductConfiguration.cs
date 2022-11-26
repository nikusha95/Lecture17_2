using EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(x => x.Amount)
            .HasDefaultValue(0);

        builder.Property(x => x.Price)
            .HasColumnType("decimal(18,2)");
        
        builder.HasMany(x => x.ProductOrders)
            .WithOne(x => x.Product)
            .HasForeignKey(x => x.ProductId)
            .HasForeignKey("FK_ProductOrders_Product");
    }
}