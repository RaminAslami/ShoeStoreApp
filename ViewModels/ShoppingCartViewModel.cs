using ShoeStoreApp.Models;

namespace ShoeStoreApp.ViewModels;

public class ShoppingCartViewModel
{
    public ShoppingCartViewModel(IShoppingCart shoppingCart, decimal shoppingcartTotal)
    {
        ShoppingCart = shoppingCart;
        ShoppingCartTotal = shoppingcartTotal;
    }
    
    public IShoppingCart ShoppingCart { get; }
    public decimal ShoppingCartTotal { get; }
    
}