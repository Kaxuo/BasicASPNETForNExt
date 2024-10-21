using Microsoft.EntityFrameworkCore;
using Testing.Contexts;
using Testing.Interface;
using Testing.Models.OrderFiles;

namespace Testing.Repository
{
    public class OrderRepository : IOrderService
    {
        protected readonly KaxouDBContext _context;
        public OrderRepository(KaxouDBContext context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetAllOrders()
        {
            return await _context.Order.Include(o => o.Customer).ToListAsync();
        }
    }
}
