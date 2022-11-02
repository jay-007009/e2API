using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.ViewModel
{
    public class ItemViewModel
    {
        
        public int ItemId { get; set; }

      
        public string ItemName { get; set; }

       
        public decimal ItemPrice { get; set; }
    }
}
