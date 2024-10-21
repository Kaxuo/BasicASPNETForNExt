using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Testing.Models.OrderFiles;

namespace Testing.Models.CustomerFiles
{
    public class Customer
    {
        [Key]
        [Required]
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = "";
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = "";
        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = "";
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
