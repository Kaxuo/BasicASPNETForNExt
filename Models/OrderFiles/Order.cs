using System.ComponentModel.DataAnnotations;
using Testing.Models.CustomerFiles;

namespace Testing.Models.OrderFiles
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }

        // Navigation property
        public Customer? Customer { get; set; }
    }

}
