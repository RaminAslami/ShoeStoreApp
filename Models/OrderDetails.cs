namespace ShoeStoreApp.Models;

public class OrderDetails
{
    public int OrderDetailsId { get; set; }
    public int OrderId { get; set; }
    public int ShoeId { get; set; }
    public int Amount { get; set; }
    public decimal Price { get; set; }
    public Shoe Shoe { get; set; } = default;
    public Order Order { get; set; } = default;
}