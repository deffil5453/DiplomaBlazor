using DiplomaRealEstate.Models;

namespace DiplomaRealEstate.Services.FavoriteServices
{
	public interface IFavoriteService
	{
		Task AddFavoriteAsync(string userid, Guid realEstateId);
        Task<List<CartItem>> GetAllCartItemForUserAsync(string userid);
		Task RemoveFavoriteAsync(string userId, Guid realEstateId);
	}
}
