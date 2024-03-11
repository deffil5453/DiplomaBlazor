using DiplomaRealEstate.InputModel;
using DiplomaRealEstate.Models;

namespace DiplomaRealEstate.Services.FavoriteServices
{
	public interface IFavoriteService
	{
		Task AddFavoriteAsync(string userid, Guid realEstateId);
	}
}
