using DiplomaRealEstate.Models;

namespace DiplomaRealEstate.Services.FavoriteServices
{
	public interface IFavoriteService
	{
		Task AddFavoriteAsync(string userid, Guid realEstateId);
        Task<List<FavoriteRealEstate>> GetAllCartItemForUserAsync(string userid);
		Task<bool> RemoveFavoriteAsync(string userId, Guid realEstateId);
		Task<bool> GetFavoriteByUserAsync(string userId,Guid realEstateId);
	}
}
