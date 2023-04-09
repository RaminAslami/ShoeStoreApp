using Microsoft.EntityFrameworkCore;

namespace ShoeStoreApp.Models;

public class ShoeRepository : IShoeRepository
{
    private readonly ShoeStoreDbContext _shoeStoreDbContext;

    public ShoeRepository(ShoeStoreDbContext shoeStoreDbContext)
    {
        _shoeStoreDbContext = shoeStoreDbContext;
    }

    public IEnumerable<Shoe> AllShoes
    {
        get
        {
            return _shoeStoreDbContext.Shoe.Include(c => c.Category);
        }
    }

    public IEnumerable<Shoe> ShoeOfTheWeek
    {
        get
        {
            return _shoeStoreDbContext.Shoe.Include(c => c.Category)
                .Where(s => s.IsShoeOfTheWeek);
        }
    }

    public Shoe? GetShoeById(int shoeId)
    {
        return _shoeStoreDbContext.Shoe.FirstOrDefault(s => s.ShoeId == shoeId);
    }

}