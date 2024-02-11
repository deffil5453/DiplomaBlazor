using DiplomaRealEstate.Models;

namespace DiplomaRealEstate.Services.RealEstateServices
{
    public interface IRealEstateService
    {
        Task <List<RealEstate>> GetAllRealEstateAsync();
        Task<RealEstate> GetRealEstateAsync(Guid realEstateId);
        Task AddRealEstateAsync(RealEstate realEstate);
        Task RemoveRealEstateAsync(Guid realEstateId);
        Task UpdateRealEstate(RealEstate realEstate);
    }
}
