using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models
{
    public class PaymentType
    {
        [Key]
        public int PaymentTypeId { get; set; }

        [Required]
        public string PaymentTypeName { get; set; }
    }
}
