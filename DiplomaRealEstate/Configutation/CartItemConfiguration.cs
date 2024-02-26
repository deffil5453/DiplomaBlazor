using DiplomaRealEstate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DiplomaRealEstate.Configutation
{
	public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
	{
		public void Configure(EntityTypeBuilder<CartItem> builder)
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
