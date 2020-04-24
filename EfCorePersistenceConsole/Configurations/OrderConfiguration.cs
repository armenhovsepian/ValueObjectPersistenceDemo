using EfCorePersistenceConsole.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCorePersistenceConsole.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.OrderId);

            builder.OwnsOne(o => o.Amount)
                .Property(p => p.Value)
                .HasColumnName("Amount")
                .IsRequired();
           
            builder.OwnsOne(o => o.RowGuid)
                .Property(p => p.Value)
                .HasColumnName("RowGuid")
                .IsRequired();

            builder.OwnsOne(o => o.OrderDate)
                .Property(p => p.Value)
                .HasColumnName("OrderDate")
                .IsRequired();
        }
    }
}
