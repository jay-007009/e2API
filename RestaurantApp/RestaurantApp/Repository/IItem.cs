using RestaurantApp.ViewModel;
using System.Collections.Generic;

namespace RestaurantApp.Repository
{
    public interface IItem
    {
        IEnumerable<ItemViewModel> GetAllItem();
    }
}
