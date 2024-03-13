using BlazorApp10.Data;
using DiplomaRealEstate.Models;
using Microsoft.EntityFrameworkCore;

namespace DiplomaRealEstate.Services.FavoriteServices
{
	public class FavoriteService : IFavoriteService
	{
		public async Task AddFavoriteAsync(string userid, Guid realEstateId)
		{
			using (RealEstateDbContext? dbContex = new RealEstateDbContext())
			{
				var cartItem = new CartItem
				{
					Id=Guid.NewGuid(),
					UserId = userid,
					RealEstateId  = realEstateId
				};
				dbContex.CartItems
					.Add(cartItem);
				await dbContex.SaveChangesAsync();
			}
		}
        public async Task<List<CartItem>> GetAllCartItemForUserAsync(string userid)
        {
            using (RealEstateDbContext? dbContex = new RealEstateDbContext())
            {
                return await dbContex.CartItems
					.Include(x => x.RealEstate)
					.Where(re => re.UserId == userid)
					.ToListAsync();
            }
        }

		public async Task RemoveFavoriteAsync(string userId, Guid realEstateId)
		{
			using (RealEstateDbContext? dbContext = new RealEstateDbContext())
			{
				var favorite = await dbContext.CartItems
					.Include(ci => ci.RealEstate)
					.FirstOrDefaultAsync(ci => ci.UserId == userId && ci.RealEstateId == realEstateId);
				dbContext.CartItems.Remove(favorite);
				await dbContext.SaveChangesAsync();

			}
		}
	}
}