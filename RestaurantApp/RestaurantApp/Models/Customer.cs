using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

       [Required]
        public string CustomerName { get; set; }
    }
}
