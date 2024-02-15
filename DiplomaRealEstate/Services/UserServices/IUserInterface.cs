using DiplomaRealEstate.Models;

namespace DiplomaRealEstate.Services.UserServices
{
    public interface IUserInterface
    {
        Task<List<User>> GetAllUserAsync();
    }
}
