using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RestaurantApp.Models
{
    public partial class Rents
    {
        public Rents()
        {
            Books = new HashSet<Books>();
        }

        public int RentId { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Quantity { get; set; }
        public string UserId { get; set; }
        public string AppUsersId { get; set; }
        public int? BookId { get; set; }

        public virtual AspNetUsers AppUsers { get; set; }
        public virtual Books Book { get; set; }
        public virtual ICollection<Books> Books { get; set; }
    }
}
