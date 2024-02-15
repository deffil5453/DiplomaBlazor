using BlazorApp10.Data;
using DiplomaRealEstate.Models;
using Microsoft.EntityFrameworkCore;

namespace DiplomaRealEstate.Services.UserServices
{
    public class UserServices : IUserInterface
    {
        public async Task<List<User>> GetAllUserAsync()
        {
            using (var dbContext = new RealEstateDbContext())
            {
                return await dbContext.User.ToListAsync();
            }
        }
    }
}
