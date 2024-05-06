using DiplomaRealEstate.Models;
using static DiplomaRealEstate.Components.Account.AddendumProfile;

namespace DiplomaRealEstate.Services.UserServices
{
    public interface IUserInterface
    {
        Task<List<User>> GetAllUserAsync();
        Task DeleteUser(string UserId);
        Task UptateUser(string UserId, UserDetailModel userDetailModel);
        Task<User> GetUserAsync(string userId);
    }
}
