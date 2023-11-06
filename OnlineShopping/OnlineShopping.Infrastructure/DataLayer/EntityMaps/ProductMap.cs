using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;

namespace OnlineShop.Infrastructure.DataLayer.EntityMaps;

public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> entity)
    {
        entity.ToTable(nameof(Product));

        entity.HasOne(product => product.Discount)
           .WithMany(discount => discount.Products)
           .HasForeignKey(course => course.DiscountId)
           .OnDelete(DeleteBehavior.NoAction);

        entity.HasOne(product => product.ProductCategory)
           .WithMany(productCategory => productCategory.Products)
           .HasForeignKey(product => product.ProductCategoryId)
           .OnDelete(DeleteBehavior.NoAction);
    }
}