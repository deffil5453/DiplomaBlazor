using BlazorApp10.Data;
using DiplomaRealEstate.InputModel;
using DiplomaRealEstate.Models;
using Microsoft.IdentityModel.Tokens;

namespace DiplomaRealEstate.Services.CategoryServices
{
	public class CategoryService : ICategoryService
	{
		public async Task AddCategoryAsync(CategoryInputModel categoryInput)
		{
			using (RealEstateDbContext? dbContext = new RealEstateDbContext())
			{
				var category = new Category
				{
					Id = Guid.NewGuid(),
					Name = categoryInput.Name,
				};
				dbContext.Categories.Add(category);
				await dbContext.SaveChangesAsync();
			}
		}
	}
}