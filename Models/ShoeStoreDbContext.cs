using Microsoft.EntityFrameworkCore;

namespace ShoeStoreApp.Models;

public class ShoeStoreDbContext: DbContext
{
    public ShoeStoreDbContext(DbContextOptions<ShoeStoreDbContext>
        options) : base(options)
    {
        
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Shoe> Shoe { get; set; }

    public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
}