namespace ShoeStoreApp.Models;

public interface IOrderRepository
{
    void CreateOrder(Order order);
}