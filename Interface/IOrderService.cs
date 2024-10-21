using Testing.Models.OrderFiles;

namespace Testing.Interface
{
    public interface IOrderService
    {
        Task<List<Order>> GetAllOrders();
    }
}
