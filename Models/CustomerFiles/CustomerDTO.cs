using Testing.Models.OrderFiles;

namespace Testing.Models.CustomerFiles
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = "";
        public ICollection<OrderSummaryDTO> Orders { get; set; } = new List<OrderSummaryDTO>();
    }

    public class OrderSummaryDTO
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; } // Only include the properties you need
    }
}
