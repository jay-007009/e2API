using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RestaurantApp.Models
{
    public partial class BookImages
    {
        public int BookImageId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int BookId { get; set; }

        public virtual Books Book { get; set; }
    }
}
