namespace ShoeStoreApp.Models;

public class ShoppingCart:IShoppingCart
{
    private readonly ShoeStoreDbContext _shoeStoreDbContext;
    public void AddToCart(Shoe shoe)
    {
        throw new NotImplementedException();
    }

    public int RemoveFromCart(Shoe shoe)
    {
        throw new NotImplementedException();
    }

    public List<ShoppingCartItem> GetShoppingCartItems()
    {
        throw new NotImplementedException();
    }

    public void ClearCart()
    {
        throw new NotImplementedException();
    }

    public decimal GetShoppingCartTotal()
    {
        throw new NotImplementedException();
    }

    public List<ShoppingCartItem> ShoppingCartItems { get; set; }
}