using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;

namespace OnlineShop.Infrastructure.DataLayer.EntityMaps;

public class ShoppingSessionMap : IEntityTypeConfiguration<ShoppingSession>
{
    public void Configure(EntityTypeBuilder<ShoppingSession> entity)
    {
        entity.ToTable(nameof(ShoppingSession));

        entity.HasKey(session => session.UserId);
    }
}
