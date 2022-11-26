using EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore.Configurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasKey(x => x.Id);//optional
        
        builder.Property(x => x.Iban)
            .IsRequired()
            .HasMaxLength(20);
        
        builder.Property(x => x.Balance)
            .HasColumnType("decimal(18,2)");
        
    }
}