using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;

namespace OnlineShop.Infrastructure.DataLayer.EntityMaps;

public class OrderDetailMap : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> entity)
    {
        entity.ToTable(nameof(OrderDetail));

        entity.HasKey(orderDetail => orderDetail.PaymentDetailId);
    }
}
