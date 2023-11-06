using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Entities;
using System.Net;

namespace OnlineShop.Infrastructure.DataLayer.EntityMaps;

public class UserPaymentMap : IEntityTypeConfiguration<UserPayment>
{
    public void Configure(EntityTypeBuilder<UserPayment> entity)
    {
        entity.ToTable(nameof(UserPayment));

        entity.Property(address => address.Id).HasColumnOrder(1);

        entity.Property(address => address.PaymentType).HasColumnOrder(2).HasMaxLength(50);

        entity.Property(address => address.Provider).HasColumnOrder(2).HasMaxLength(50);

        entity.HasOne(userPayment => userPayment.User)
           .WithMany(user => user.userPayments)
           .HasForeignKey(userPayment => userPayment.UserId)
           .OnDelete(DeleteBehavior.NoAction);


    }
}
