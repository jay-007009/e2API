using RestaurantApp.Models;
using System.Collections.Generic;
using System.Linq;
using RestaurantApp.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp.Repository
{
    public class CustomerRepository : ICustomer
    {
        private TraineeDemo1Context _traineeDemo;
        public CustomerRepository()
        {
            _traineeDemo = new TraineeDemo1Context();
        }
        public IEnumerable<CustomerViewModel> GetAllCustomer()
        {


            var CustomerDTOs = _traineeDemo.Customers.Select(customermodel => new CustomerViewModel
            {
                CustomerId = customermodel.CustomerId,
                CustomerName = customermodel.CustomerName
            }).ToList();



            return CustomerDTOs;
        }


        public decimal getItemPrice(int itemId)
        {
            //  var _Item = new Items();
            // var _Item = _traineeDemo.Items.Single(model => model.ItemId == itemId).ItemPrice;
            //if(_Item!=null)
            //    if(_Item.ItemPrice>0)
            //        return _Item.ItemPrice;
            //else
            //        return 0;
            // return _Item;

            var _Item = _traineeDemo.Items.FirstOrDefault(model => model.ItemId == itemId).ItemPrice;
            return _Item;

        }
    }
}
