using ShoeStoreApp.Models;

namespace ShoeStoreApp.ViewModels;

public class ShoeListViewModel
{
    public IEnumerable<Shoe> Shoes { get; set; }
    public string? CurrentCategory { get; }

    public ShoeListViewModel(IEnumerable<Shoe> shoes, string? currentCategory)
    {
        Shoes = shoes;
        CurrentCategory = currentCategory;
    }
}