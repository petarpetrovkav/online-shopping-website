using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;

namespace OnlineShop.Infrastructure.DataLayer.EntityMaps;

public class CartItemMap : IEntityTypeConfiguration<CartItem>
{
    public void Configure(EntityTypeBuilder<CartItem> entity)
    {
        entity.ToTable(nameof(CartItem));

        entity.HasOne(CartItem => CartItem.ShoppingSession)
           .WithMany(shoppingSession => shoppingSession.CartItems)
           .HasForeignKey(cartItem => cartItem.ShoppingSessionId)
           .OnDelete(DeleteBehavior.NoAction);
    }
}
