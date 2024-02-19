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
                    Price = realEstateinput.Price,
                    Rooms = realEstateinput.Rooms,
                    Desctiption = "тута текст прост так",
                    Country = realEstateinput.Country,
                    Region = realEstateinput.Region,
                    City =  realEstateinput.City,
                    Street = realEstateinput.Street,
                    House = realEstateinput.House,
                    Latitude = realEstateinput.Latitude,
                    Longitude = realEstateinput.Longitude,
                    Photos = realEstateinput.Photos,
                    UserId = realEstateinput.UserId,
                    TypeRealEstateId = realEstateinput.TypeRealEstateId,
                    StatusId = dbContext.Statuses.First().Id,
                    CategoryId = realEstateinput.CategoryId,
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
