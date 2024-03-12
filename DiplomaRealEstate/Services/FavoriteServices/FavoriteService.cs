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
				Random rnd = new Random();
				int CartId = rnd.Next(1000000);
				var cartItem = new CartItem
				{
					Id=CartId,
					UserId = userid,
					RealEstateId  = realEstateId
				};
				await dbContex.CartItems.AddAsync(cartItem);
				await dbContex.SaveChangesAsync();
			}
		}
	}
}