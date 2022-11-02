using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RestaurantApp.Models
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int? Userid { get; set; }
        public int? Quantity { get; set; }
        public DateTime? Orderdate { get; set; }
    }
}
