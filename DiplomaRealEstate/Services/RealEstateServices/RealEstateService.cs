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
					City = realEstateinput.City,
					Street = realEstateinput.Street,
					House = realEstateinput.House,
					Latitude = realEstateinput.Latitude,
					Longitude = realEstateinput.Longitude,
					Photos = realEstateinput.Photos,
					UserId = realEstateinput.UserId,
					TypeRealEstateId = realEstateinput.TypeRealEstateId,
					TypeSaleId = realEstateinput.TypeSalesId,
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
				return await dbContext.RealEstates.Include(i=>i.TypeSale).ToListAsync();
			}
		}
		public async Task<List<RealEstate>> GetAllRealEstateIUserAsync(string userId)
		{
			using (var dbContext = new RealEstateDbContext())
			{
				return await dbContext.RealEstates.Where(re => re.UserId == userId).ToListAsync();
			}
		}
		public async Task<List<TypeRealEstate>> GetAllTypeAsync()
		{
			using (var dbContext = new RealEstateDbContext())
			{
				return await dbContext.TypeRealEstates.ToListAsync();
			}
		}

        public async Task<List<TypeSale>> GetAllTypeSaleAsync()
        {
            using (var dbContext = new RealEstateDbContext())
            {
                return await dbContext.TypeSales.ToListAsync();
            }
        }

        public async Task<RealEstateEditModel> GetRealEstateAsync(Guid realEstateId)
		{
			using (var dbContext = new RealEstateDbContext())
			{
				var realEstate = await dbContext.RealEstates.Where(re => re.Id == realEstateId)
					.Select(realEstate => new RealEstateEditModel
					{
						Id = realEstateId,
						Area = realEstate.Area,
						CategoryId = realEstate.CategoryId,
						City = realEstate.City,
						Country = realEstate.Country,
						Desctiption = realEstate.Desctiption,
						House = realEstate.House,
						Latitude = realEstate.Latitude,
						Longitude = realEstate.Longitude,
						Photos = realEstate.Photos,
						Price = realEstate.Price,
						Region = realEstate.Region,
						Rooms = realEstate.Rooms,
						Street = realEstate.Street,
						TypeRealEstateId = realEstate.TypeRealEstateId,
						UserId = realEstate.UserId
					})
					.FirstOrDefaultAsync();
				return realEstate;
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
		public async Task UpdateRealEstate(Guid Id, RealEstateEditModel model)
		{
			using (var dbContext = new RealEstateDbContext())
			{
				var realEstate = await dbContext.RealEstates.FirstOrDefaultAsync(re=>re.Id==Id);
				realEstate.Area = model.Area;
				realEstate.Price = model.Price;
				realEstate.Rooms = model.Rooms;
				realEstate.Desctiption = model.Desctiption;
				realEstate.Country = model.Country;
				realEstate.Region = model.Region;
				realEstate.City = model.City;
				realEstate.Street = model.Street;
				realEstate.House = model.House;
				realEstate.Latitude = model.Latitude;
				realEstate.Longitude = model.Longitude;
				realEstate.Photos = model.Photos;
				realEstate.TypeRealEstateId = model.TypeRealEstateId;
				realEstate.CategoryId = model.CategoryId;
				dbContext.RealEstates.Update(realEstate);
				await dbContext.SaveChangesAsync();
			}
		}
	}
}
