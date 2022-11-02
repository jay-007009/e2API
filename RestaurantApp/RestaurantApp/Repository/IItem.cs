using RestaurantApp.ViewModel;
using System.Collections.Generic;

namespace RestaurantApp.Repository
{
    public interface IItem
    {
        List<ItemViewModel> GetAllItem();
    }
}
