using Microsoft.EntityFrameworkCore;
using ShoeStoreApp.Models;

namespace ShoeStoreApp.Models
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly ShoeStoreDbContext _shoeStoreDbContext;

        public string? ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;

        private ShoppingCart(ShoeStoreDbContext bethanysPieShopDbContext)
        {
            _shoeStoreDbContext = bethanysPieShopDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

            ShoeStoreDbContext context = services.GetService<ShoeStoreDbContext>() ?? throw new Exception("Error initializing");

            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

            session?.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Shoe pie)
        {
            var shoppingCartItem =
                _shoeStoreDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Shoe.ShoeId == pie.ShoeId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Shoe = pie,
                    Amount = 1
                };

                _shoeStoreDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _shoeStoreDbContext.SaveChanges();
        }

        public int RemoveFromCart(Shoe shoe)
        {
            var shoppingCartItem =
                _shoeStoreDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Shoe.ShoeId == shoe.ShoeId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _shoeStoreDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _shoeStoreDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??=
                       _shoeStoreDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.Shoe)
                           .ToList();
        }

        public void ClearCart()
        {
            var cartItems = _shoeStoreDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _shoeStoreDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _shoeStoreDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _shoeStoreDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Shoe.Price * c.Amount).Sum();
            return total;
        }
    }
}
