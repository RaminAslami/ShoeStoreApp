using Microsoft.AspNetCore.Mvc;
using ShoeStoreApp.Models;

namespace ShoeStoreApp.Components;

public class CategoryMeny: ViewComponent
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryMeny(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public IViewComponentResult Invoke()
    {
        var categories = _categoryRepository.AllCategories
            .OrderBy(c => c.CategoryName);
        return View(categories);
    }

}