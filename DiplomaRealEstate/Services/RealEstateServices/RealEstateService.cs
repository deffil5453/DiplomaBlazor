using BlazorApp10.Data;
using DiplomaRealEstate.Models;
using Microsoft.EntityFrameworkCore;

namespace DiplomaRealEstate.Services.RealEstateServices
{
    public class RealEstateService : IRealEstateService
    {
        public async Task AddRealEstateAsync(RealEstate realEstate)
        {
            using (var dbContext = new RealEstateDbContext())
            {
                await dbContext.RealEstates.AddAsync(realEstate);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Category>> GetAllCategoryAsync()
        {
            using (var dbContext = new RealEstateDbContext())
            {
                return await dbContext.Categories.ToListAsync();
            }
        }

        public async Task<List<RealEstate>> GetAllRealEstateAsync()
        {
            using (var dbContext = new RealEstateDbContext())
            {
                return await dbContext.RealEstates.ToListAsync();
            }
        }

        public async Task<RealEstate> GetRealEstateAsync(Guid realEstateId)
        {
            using (var dbContext = new RealEstateDbContext())
            {
                return await dbContext.RealEstates.FindAsync(realEstateId);
            }
        }

        public async Task RemoveRealEstateAsync(Guid realEstateId)
        {
            using (var dbContext = new RealEstateDbContext())
            {
                var realEstate = await dbContext.RealEstates.FindAsync(realEstateId);
                if (realEstate != null)
                {
                    dbContext.RealEstates.Remove(realEstate);
                    await dbContext.SaveChangesAsync();
                }
            }
        }

        public async Task UpdateRealEstate(RealEstate realEstate)
        {
            using (var dbContext = new RealEstateDbContext())
            {
                dbContext.RealEstates.Update(realEstate);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
