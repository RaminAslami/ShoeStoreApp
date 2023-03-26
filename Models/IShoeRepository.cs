namespace ShoeStoreApp.Models;

public interface IShoeRepository
{
    IEnumerable<Shoe> AllShoes { get; }
    IEnumerable<Shoe> ShoeOfTheWeek { get; }
    Shoe? GetShoeById(int shoeId);

}