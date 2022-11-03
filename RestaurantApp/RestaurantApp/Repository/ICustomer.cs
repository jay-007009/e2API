using RestaurantApp.ViewModel;
using System.Collections.Generic;

namespace RestaurantApp.Repository
{
    public interface ICustomer
    {
        IEnumerable<CustomerViewModel> GetAllCustomer();
        decimal getItemPrice(int itemId);
    }
}
