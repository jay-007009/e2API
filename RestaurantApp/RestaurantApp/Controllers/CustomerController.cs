using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Repository;
using RestaurantApp.ViewModel;
using System;
using System.Collections.Generic;

namespace RestaurantApp.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomer _customer;
        private IItem _item;
        private IPaymentType _paymentType;
        public CustomerController(ICustomer customer, IItem item, IPaymentType paymentType)
        {
            _customer = customer;
            _item = item;
            _paymentType = paymentType;
        }

        public IActionResult Index()
        {
            var objmultiple = new Tuple<IEnumerable<CustomerViewModel>, IEnumerable<ItemViewModel>, IEnumerable<PaymentTypeViewModel>>(_customer.GetAllCustomer(),
                _item.GetAllItem(), _paymentType.GetAllPaymentType());

            return View(objmultiple);
        }

      //  [HttpGet]
        public JsonResult getItemPrice(int ItemId)
        {
            decimal price = _customer.getItemPrice(ItemId);
            return Json(price);
        }
    }
}
