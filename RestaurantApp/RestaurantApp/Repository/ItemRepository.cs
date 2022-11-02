using RestaurantApp.Models;
using RestaurantApp.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp.Repository
{
    public class ItemRepository :IItem
    {

        private TraineeDemo1Context _traineeDemo;
        public ItemRepository()
        {
            _traineeDemo = new TraineeDemo1Context();
        }
        public List<ItemViewModel> GetAllItem()
        {
            var ItemDTOs = _traineeDemo.Items.Select(itemmodel => new ItemViewModel
            {
                ItemId = itemmodel.ItemId,
                ItemName = itemmodel.ItemName
            }).ToList();
            return ItemDTOs;
        }
    }
}
