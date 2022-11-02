using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RestaurantApp.Models
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string UserId { get; set; }
        public string AppUsersId { get; set; }
        public int BookId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual AspNetUsers AppUsers { get; set; }
        public virtual Books Book { get; set; }
    }
}
