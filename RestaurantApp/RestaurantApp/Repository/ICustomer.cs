using RestaurantApp.ViewModel;
using System.Collections.Generic;

namespace RestaurantApp.Repository
{
    public interface ICustomer
    {
        List<CustomerViewModel> GetAllCustomer();
    }
}
