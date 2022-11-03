using RestaurantApp.ViewModel;
using System.Collections.Generic;

namespace RestaurantApp.Repository
{
    public interface IPaymentType
    {
        IEnumerable<PaymentTypeViewModel> GetAllPaymentType();
    }
}
