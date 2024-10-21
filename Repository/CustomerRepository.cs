using Microsoft.EntityFrameworkCore;
using Testing.Contexts;
using Testing.Interface;
using Testing.Models.CustomerFiles;

namespace Testing.Repository
{
    public class CustomerRepository : ICustomerService
    {
        protected readonly KaxouDBContext _context;
        public CustomerRepository(KaxouDBContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _context.Customer.Include(c => c.Orders).ToListAsync();
        }
    }
}
