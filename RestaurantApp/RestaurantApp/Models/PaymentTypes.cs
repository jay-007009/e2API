using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RestaurantApp.Models
{
    public partial class PaymentTypes
    {
        public int PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; }
    }
}
