namespace ShoeStoreApp.Models;

public class OrderRepository: IOrderRepository
{

    private readonly ShoeStoreDbContext _shoeStoreDbContext;
    private readonly IShoppingCart _shoppingCart;

    public OrderRepository(ShoeStoreDbContext shoeStoreDbContext,
        IShoppingCart shoppingCart)
    {
        _shoeStoreDbContext = shoeStoreDbContext;
        shoppingCart = _shoppingCart;
    }

    public void CreateOrder(Order order)
    {
       order.OrderPlaced = DateTime.Now;
       
       List<ShoppingCartItem>? shoppingCartItems = _shoppingCart
           .ShoppingCartItems;

       order.OrderDetails = new List<OrderDetails>();
       
       //details

       foreach (ShoppingCartItem? shoppingCartItem in shoppingCartItems)
       {
           var orderDetail = new OrderDetails
           {
               Amount = shoppingCartItem.Amount,
               ShoeId = shoppingCartItem.Shoe.ShoeId,
               Price = shoppingCartItem.Shoe.Price
           };
           order.OrderDetails.Add(orderDetail);
       }

       _shoeStoreDbContext.Orders.Add(order);
       _shoeStoreDbContext.SaveChanges();
    }
}