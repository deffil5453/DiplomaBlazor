using BlazorApp10.Data;
using DiplomaRealEstate.InputModel;
using DiplomaRealEstate.Models;

namespace DiplomaRealEstate.Services.TypeService
{
	public class TypeService : ITypeService
	{
		public async Task AddtypeRealEstate(TypeRealEstateInputModel realEstateInputModel)
		{
			using (RealEstateDbContext? dbContext = new RealEstateDbContext())
			{
				var typeRealEstate = new TypeRealEstate
				{
					Id = Guid.NewGuid(),
					Name = realEstateInputModel.Name
				};
				dbContext.TypeRealEstates.Add(typeRealEstate);
				await dbContext.SaveChangesAsync();
			}
		}
	}
}
