using DiplomaRealEstate.InputModel;
using DiplomaRealEstate.Models;

namespace DiplomaRealEstate.Services.RealEstateServices
{
    public interface IRealEstateService
    {
        Task <List<RealEstate>> GetAllRealEstateAsync();
		Task<List<RealEstate>> GetAllRealEstateIUserAsync(string userId);
		Task<RealEstateEditModel> GetRealEstateAsync(Guid realEstateId);
        Task AddRealEstateAsync(RealEstateInputModel realEstateinput);
        Task RemoveRealEstateAsync(Guid realEstateId);
		Task UpdateRealEstate(Guid Id, RealEstateEditModel model);
        Task<List<Category>> GetAllCategoryAsync();
        Task<List<TypeRealEstate>> GetAllTypeAsync();
    }
}