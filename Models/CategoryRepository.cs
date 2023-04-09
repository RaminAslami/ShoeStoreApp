using Microsoft.EntityFrameworkCore;

namespace ShoeStoreApp.Models;

public class CategoryRepository: ICategoryRepository
{
    private readonly ShoeStoreDbContext _shoeStoreDbContext;

    public CategoryRepository(ShoeStoreDbContext shoeStoreDbContext)
    {
        _shoeStoreDbContext = shoeStoreDbContext;
    }
    public IEnumerable<Category> AllCategories
    {
        get
        {
          return  _shoeStoreDbContext.Categories.OrderBy(c => c.CategoryName);
        }
    }
}