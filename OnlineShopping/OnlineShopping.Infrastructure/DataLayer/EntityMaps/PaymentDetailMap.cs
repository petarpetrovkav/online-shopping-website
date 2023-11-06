using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;

namespace OnlineShop.Infrastructure.DataLayer.EntityMaps;

public class PaymentDetailMap : IEntityTypeConfiguration<PaymentDetail>
{
    public void Configure(EntityTypeBuilder<PaymentDetail> entity)
    {
        entity.ToTable(nameof(PaymentDetail));
    }
}
