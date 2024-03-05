using DiplomaRealEstate.InputModel;
using DiplomaRealEstate.Models;

namespace DiplomaRealEstate.Services.CategoryServices
{
	public interface ICategoryService
	{
		Task AddCategoryAsync(CategoryInputModel categoryInput);
	}
}
