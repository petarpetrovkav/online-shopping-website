using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Entities;

namespace OnlineShop.Infrastructure.DataLayer.EntityMaps;

public class UserAddresMap : IEntityTypeConfiguration<UserAddres>
{
    public void Configure(EntityTypeBuilder<UserAddres> entity)
    {
        entity.ToTable(nameof(UserAddres));

        entity.HasOne(userAddress => userAddress.User)
           .WithMany(user => user.userAddresses)
           .HasForeignKey(userAddres => userAddres.UserId)
           .OnDelete(DeleteBehavior.NoAction);


    }
}
