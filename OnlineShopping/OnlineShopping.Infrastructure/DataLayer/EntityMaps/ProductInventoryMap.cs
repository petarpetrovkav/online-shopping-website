using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;

namespace OnlineShop.Infrastructure.DataLayer.EntityMaps;

public class ProductInventoryMap : IEntityTypeConfiguration<ProductInventory>
{
    public void Configure(EntityTypeBuilder<ProductInventory> entity)
    {
        entity.ToTable(nameof(ProductInventory));

        entity.HasKey(inventory => inventory.ProductId);
    }
}
