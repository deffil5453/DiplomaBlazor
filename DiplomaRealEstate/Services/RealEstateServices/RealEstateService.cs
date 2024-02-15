using BlazorApp10.Data;
using DiplomaRealEstate.InputModel;
using DiplomaRealEstate.Models;
using Microsoft.EntityFrameworkCore;

namespace DiplomaRealEstate.Services.RealEstateServices
{
    public class RealEstateService : IRealEstateService
    {
        public async Task AddRealEstateAsync(RealEstateInputModel realEstateinput)
        {
            using (var dbContext = new RealEstateDbContext())
            {
                var realEstate = new RealEstate()
                {
                    Id = Guid.NewGuid(),
                    Area = realEstateinput.Area,
                    CategoryId = realEstateinput.CategoryId,
                    Latitude = realEstateinput.Latitude,
                    Longitude = realEstateinput.Longitude,
                    Country = realEstateinput.Country,
                    Photos = realEstateinput.Photos,
                    Price = realEstateinput.Price,
                    House = realEstateinput.House,
                    Street = realEstateinput.Street,
                    Rooms = realEstateinput.Rooms,
                    TypeRealEstateId = realEstateinput.TypeRealEstateId,
                    UserId = realEstateinput.UserId,
                    StatusId = dbContext.Statuses.First().Id
                };
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

        public async Task<List<TypeRealEstate>> GetAllTypeAsync()
        {
            using (var dbContext = new RealEstateDbContext())
            {
                return await dbContext.TypeRealEstates.ToListAsync();
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
