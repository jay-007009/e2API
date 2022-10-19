using e2API.Models;

namespace e2API.Service
{
    public interface IDataAccess
    {
        Cart GetActiveCartOfUser(int userid);
        List<Cart> GetAllPreviousCartsOfUser(int userid);
        Cart GetCart(int cartid);
        Offer GetOffer(int id);
        List<PaymentMethod> GetPaymentMethods();
        Book GetBook(int id);
        List<BookCategory> GetBookCategories();
        BookCategory GetBookCategory(int id);
        List<Review> GetBookReviews(int bookId);
        List<Book> GetBooks(string category, string subcategory, int count);

        User GetUser(int id);
        bool InsertCartItem(int userId, int bookId);
        int InsertOrder(Order order);
        int InsertPayment(Payment payment);

        void InsertReview(Review review);

        bool InsertUser(User user);

        string IsUserPresent(string email, string password);
    }
}
