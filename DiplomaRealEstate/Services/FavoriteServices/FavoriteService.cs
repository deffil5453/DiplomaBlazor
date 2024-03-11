using BlazorApp10.Data;
using DiplomaRealEstate.Models;

namespace DiplomaRealEstate.Services.FavoriteServices
{
	public class FavoriteService : IFavoriteService
	{
		public async Task AddFavoriteAsync(string userid, Guid realEstateId)
		{
			using (var dbContex = new RealEstateDbContext())
			{
				var cartItem = new CartItem()
				{
					Id=1,
					UserId = userid,
					RealEstateId  = realEstateId
				};
				await dbContex.CartItems.AddAsync(cartItem);
				await dbContex.SaveChangesAsync();
			}
		}
	}
}
