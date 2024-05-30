using BlazorApp10.Data;
using DiplomaRealEstate.InputModel;
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

        public async Task UptateUser(string UserId, User userDetail)
        {
            using (var dbContext = new RealEstateDbContext())
            {
                var user = await dbContext.User.FirstOrDefaultAsync(u => u.Id == UserId);
                user.LastName = userDetail.LastName;
                user.FirstName = userDetail.FirstName;
                user.MiddleName = userDetail.MiddleName;
                user.PhoneNumber = userDetail.PhoneNumber;
                user.ImageProfile = userDetail.ImageProfile;
                user.PhoneNumberConfirmed = true;
                
                dbContext.User.Update(user);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
