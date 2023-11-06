using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;

namespace OnlineShop.Infrastructure.DataLayer.EntityMaps;

public class OrderItemMap : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> entity)
    {
        entity.ToTable(nameof(OrderItem));

        entity.HasOne(orderItem => orderItem.OrderDetail)
           .WithMany(orderDetail => orderDetail.Orderitems)
           .HasForeignKey(course => course.OrderDetailsId)
           .OnDelete(DeleteBehavior.NoAction);
    }
}
