using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RestaurantApp.Models
{
    public partial class Students
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string AppUsersId { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public int BookId { get; set; }

        public virtual AspNetUsers AppUsers { get; set; }
        public virtual Books Book { get; set; }
    }
}
