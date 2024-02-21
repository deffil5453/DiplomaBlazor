using DiplomaRealEstate.InputModel;
using DiplomaRealEstate.Models;

namespace DiplomaRealEstate.Services.RealEstateServices
{
    public interface IRealEstateService
    {
        Task <List<RealEstate>> GetAllRealEstateAsync();
		Task<List<RealEstate>> GetAllRealEstateIUserAsync(string userId);
		Task<RealEstate> GetRealEstateAsync(Guid realEstateId);
        Task AddRealEstateAsync(RealEstateInputModel realEstateinput);
        Task RemoveRealEstateAsync(Guid realEstateId);
        Task UpdateRealEstate(RealEstate realEstate);
        Task<List<Category>> GetAllCategoryAsync();
        Task<List<TypeRealEstate>> GetAllTypeAsync();
    }
}
