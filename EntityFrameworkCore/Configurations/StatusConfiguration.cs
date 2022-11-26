using EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.Configurations;

public class StatusConfiguration: IEntityTypeConfiguration<Status>
{
    public void Configure(EntityTypeBuilder<Status> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasMany(x => x.Orders)
            .WithOne(x => x.Status)
            .HasForeignKey(x => x.StatusId)
            .HasConstraintName("FK_Statuses_Order");


        builder.HasData(new List<Status>
        {
            new()
            {
                Id = 1,
                Name = "In Progress"
            },
            new()
            {
                Id = 2,

                Name = "Failed"
            },
            new()
            {
                Id = 3,

                Name = "Done"
            },
        });
    }
}