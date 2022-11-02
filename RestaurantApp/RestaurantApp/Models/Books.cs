using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RestaurantApp.Models
{
    public partial class Books
    {
        public Books()
        {
            BookImages = new HashSet<BookImages>();
            Cart = new HashSet<Cart>();
            Students = new HashSet<Students>();
        }

        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuhorName { get; set; }
        public string AuthorContactNo { get; set; }
        public string PublisherName { get; set; }
        public int Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CategoryId { get; set; }
        public int RentId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Rents Rent { get; set; }
        public virtual Rents Rents { get; set; }
        public virtual ICollection<BookImages> BookImages { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Students> Students { get; set; }
    }
}
