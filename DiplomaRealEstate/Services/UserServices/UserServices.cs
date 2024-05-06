using BlazorApp10.Data;
using DiplomaRealEstate.Models;
using Microsoft.EntityFrameworkCore;
using static DiplomaRealEstate.Components.Account.AddendumProfile;

namespace DiplomaRealEstate.Services.UserServices
{
    public class UserServices : IUserInterface
    {
        public async Task DeleteUser(string UserId)
        {
            using (var dbContext = new RealEstateDbContext())
            {
                var user = await dbContext.User.FindAsync(UserId);
                if (user != null)
                {
                    dbContext.User.Remove(user);
                    await dbContext.SaveChangesAsync();
                }
            }
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            using (var dbContext = new RealEstateDbContext())
            {
                return await dbContext.User.ToListAsync();
            }
        }

        public async Task<User> GetUserAsync(string userId)
        {
            using (var dbContext = new RealEstateDbContext())
            {
                return await dbContext.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
            }
        }

        public async Task UptateUser(string UserId, UserDetailModel userDetailModel)
        {
            using (var dbContext = new RealEstateDbContext())
            {
                var user = await dbContext.User.FirstOrDefaultAsync(u => u.Id == UserId);
                user.LastName = userDetailModel.LastName;
                user.FirstName = userDetailModel.FirstName;
                user.MiddleName = userDetailModel.MiddleName;
                user.PhoneNumber = userDetailModel.PhoneNumber;
                user.PhoneNumberConfirmed = true;
                
                dbContext.User.Update(user);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
