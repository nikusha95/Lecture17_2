using EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.Property(x => x.CreateDate)
            .HasDefaultValueSql("GETDATE()");//DateTime.Now

        builder.HasMany(x => x.ProductOrders)
            .WithOne(x => x.Order)
            .HasForeignKey(x => x.OrderId)
            .HasForeignKey("FK_ProductOrders_Order");
    }
}