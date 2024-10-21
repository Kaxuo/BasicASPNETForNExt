using Testing.Models.CustomerFiles;

namespace Testing.Models.OrderFiles
{
    public class OrderDTO
    {
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; } // Include CustomerId
        public CustomerInfoDTO Customer { get; set; } = new CustomerInfoDTO();
    }

    public class CustomerInfoDTO
    {
        public string Name { get; set; } = "";
        public string LastName { get; set; } = "";
    }
}
