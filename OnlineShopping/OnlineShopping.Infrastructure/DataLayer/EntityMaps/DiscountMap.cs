using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;

namespace OnlineShop.Infrastructure.DataLayer.EntityMaps;

public class DiscountMap : IEntityTypeConfiguration<Discount>
{
    public void Configure(EntityTypeBuilder<Discount> entity)
    {
        entity.ToTable(nameof(Discount));
    }
}
