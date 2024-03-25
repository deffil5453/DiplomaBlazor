using DiplomaRealEstate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiplomaRealEstate.Configutation
{
	public class CartItemConfiguration : IEntityTypeConfiguration<FavoriteRealEstate>
	{
		public void Configure(EntityTypeBuilder<FavoriteRealEstate> builder)
		{
			builder
				.HasOne(cart => cart.RealEstate)
				.WithMany(realEstate => realEstate.CartItems)
				.HasForeignKey(ci => ci.RealEstateId)
				.OnDelete(DeleteBehavior.ClientSetNull);

			builder
				.HasOne(cart => cart.User)
				.WithMany(user => user.CartItems)
				.HasForeignKey(ci => ci.UserId)
				.OnDelete(DeleteBehavior.ClientSetNull);
		}
	}
}
