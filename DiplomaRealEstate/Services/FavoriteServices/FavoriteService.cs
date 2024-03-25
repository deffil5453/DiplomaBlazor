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
				var cartItem = new FavoriteRealEstate
				{
					Id=Guid.NewGuid(),
					UserId = userid,
					RealEstateId  = realEstateId
				};
				dbContex.FavoriteRealEstates
					.Add(cartItem);
				await dbContex.SaveChangesAsync();
			}
		}
        public async Task<List<FavoriteRealEstate>> GetAllCartItemForUserAsync(string userid)
        {
            using (RealEstateDbContext? dbContex = new RealEstateDbContext())
            {
                return await dbContex.FavoriteRealEstates
					.Include(x => x.RealEstate)
					.Where(re => re.UserId == userid)
					.ToListAsync();
            }
        }

        public async Task<bool> GetFavoriteByUserAsync(string userId, Guid realEstateId)
        {
            using (RealEstateDbContext? dbContext = new RealEstateDbContext())
            {
                var favorite = await dbContext.FavoriteRealEstates.Include(ci => ci.RealEstate)
                    .FirstOrDefaultAsync(ci => ci.UserId == userId && ci.RealEstate.Id == realEstateId);
                if (favorite == null)
				{
					return false;
				}
				return true;
            }
        }

        public async Task<bool> RemoveFavoriteAsync(string userId, Guid realEstateId)
		{
			using (RealEstateDbContext? dbContext = new RealEstateDbContext())
			{
				var favorite = await dbContext.FavoriteRealEstates
					.Include(ci => ci.RealEstate)
					.FirstOrDefaultAsync(ci => ci.UserId == userId && ci.RealEstate.Id == realEstateId);
				dbContext.FavoriteRealEstates.Remove(favorite);
				await dbContext.SaveChangesAsync();
				return true;
			}
		}
	}
}