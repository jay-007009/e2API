using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantApp.Models;
using RestaurantApp.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp.Repository
{
    public class PaymentTypeRepository :IPaymentType
    {
        private TraineeDemo1Context _traineeDemo;
        public PaymentTypeRepository()
        {
            _traineeDemo = new TraineeDemo1Context();
        }

        public List<PaymentTypeViewModel> GetAllPaymentType()
        {
            var PaymentDTOs = _traineeDemo.PaymentTypes.Select(paymentmodel => new PaymentTypeViewModel
            {
                PaymentTypeId = paymentmodel.PaymentTypeId,
                PaymentTypeName = paymentmodel.PaymentTypeName
            }).ToList();
            return PaymentDTOs;
        }
    }
}
