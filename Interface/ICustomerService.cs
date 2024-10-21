using Testing.Models.CustomerFiles;

namespace Testing.Interface
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomers();
    }
}
