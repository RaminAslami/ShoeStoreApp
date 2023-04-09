using ShoeStoreApp.Models;

namespace ShoeStoreApp.ViewModels;

public class HomeViewModel
{
    public IEnumerable<Shoe> ShoesOfTheWeek { get; }

    public HomeViewModel(IEnumerable<Shoe> shoesOfTheWeek)
    {
        ShoesOfTheWeek = shoesOfTheWeek;
    }
}