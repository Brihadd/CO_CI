using CO_CI.Models;

namespace CO_CI.Services
{
    public interface IOrderService
    {
        Task<Order[]> GetOrdersByParameters(OrderParametr orderParametr);
        Task<Order> CreateOrder(Order order);
        Task<Order> UpdateOrder(Order order);
        Task<bool> DeleteOrder(int orderId);
    }
}
