using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RestaurantApp.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string BookInfo { get; set; }
        public int? Bookquantity { get; set; }
        public int? Price { get; set; }
        public string BookImagefile { get; set; }
        public int? CategoryId { get; set; }
        public string Author { get; set; }
    }
}
