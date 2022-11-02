using RestaurantApp.Models;
using System.Collections.Generic;
using System.Linq;
using RestaurantApp.ViewModel;
namespace RestaurantApp.Repository
{
    public class CustomerRepository: ICustomer
    {
        private TraineeDemo1Context _traineeDemo;
        public CustomerRepository()
        {
            _traineeDemo = new TraineeDemo1Context();
        }
        public List<CustomerViewModel> GetAllCustomer()
        {
            var CustomerDTOs = _traineeDemo.Customers.Select(customermodel => new CustomerViewModel
            {
                CustomerId = customermodel.CustomerId,
                CustomerName = customermodel.CustomerName
            }).ToList();
            return CustomerDTOs;
        }


    }
}
