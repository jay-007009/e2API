using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RestaurantApp.Models
{
    public partial class Reports
    {
        public int ReportId { get; set; }
        public string CustomerName { get; set; }
        public int Total { get; set; }
    }
}
