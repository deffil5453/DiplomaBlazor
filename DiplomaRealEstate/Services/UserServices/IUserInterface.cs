using DiplomaRealEstate.InputModel;
using DiplomaRealEstate.Models;

namespace DiplomaRealEstate.Services.UserServices
{
    public interface IUserInterface
    {
        Task<List<User>> GetAllUserAsync();
        Task DeleteUser(string UserId);
        Task UptateUser(string UserId, User userDetail);
        Task<User> GetUserAsync(string userId);
    }
}
