using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public decimal ItemPrice { get; set; }
    }
}
