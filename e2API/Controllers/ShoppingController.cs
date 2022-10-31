using e2API.Models;
using e2API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e2API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        readonly IDataAccess dataAccess;
        private readonly string DateFormat;
        public ShoppingController(IDataAccess dataAccess, IConfiguration configuration)
        {
            this.dataAccess = dataAccess;
            DateFormat = configuration["Constants:DateFormat"];
        }

        [HttpGet("GetCategoryList")]
        public IActionResult GetCategoryList()
        {
            var result = dataAccess.GetBookCategories();
            return Ok(result);
        }

        [HttpGet("GetBooks")]
        public IActionResult GetBooks(string category, string subcategory, int count)
        {
            var result = dataAccess.GetBooks(category, subcategory, count);
            return Ok(result);
        }

        [HttpGet("GetBook/{id}")]
        public IActionResult GetBook(int id)
        {
            var result = dataAccess.GetBook(id);
            return Ok(result);
        }

        [HttpPost("RegisterUser")]
        public IActionResult RegisterUser([FromBody] User user)
        {
            user.CreatedAt = DateTime.Now.ToString(DateFormat);
            user.ModifiedAt = DateTime.Now.ToString(DateFormat);

            var result = dataAccess.InsertUser(user);

            string? message;
            if (result) message = "inserted";
            else message = "Email not Found";
            return Ok(message);
        }

        [HttpPost("LoginUser")]
        public IActionResult LoginUser([FromBody] User user)
        {
            var token = dataAccess.IsUserPresent(user.Email, user.Password);
            if (token == "") token = "Invalid token";
            return Ok(token);
        }

        [HttpPost("InsertReview")]
        public IActionResult InsertReview([FromBody] Review review)
        {
            review.CreatedAt = DateTime.Now.ToString(DateFormat);
            dataAccess.InsertReview(review);
            return Ok("inserted");
        }

        [HttpGet("GetBookReviews/{bookId}")]
        public IActionResult GetBookReviews(int bookId)
        {
            var result = dataAccess.GetBookReviews(bookId);
            return Ok(result);
        }

        [HttpPost("InsertCartItem/{userid}/{bookid}")]
        public IActionResult InsertCartItem(int userid, int bookid)
        {
            var result = dataAccess.InsertCartItem(userid, bookid);
            return Ok(result ? "inserted" : "not inserted");
        }

        [HttpGet("GetActiveCartOfUser/{id}")]
        public IActionResult GetActiveCartOfUser(int id)
        {
            var result = dataAccess.GetActiveCartOfUser(id);
            return Ok(result);
        }

        [HttpGet("GetAllPreviousCartsOfUser/{id}")]
        public IActionResult GetAllPreviousCartsOfUser(int id)
        {
            var result = dataAccess.GetAllPreviousCartsOfUser(id);
            return Ok(result);
        }

        [HttpGet("GetPaymentMethods")]
        public IActionResult GetPaymentMethods()
        {
            var result = dataAccess.GetPaymentMethods();
            return Ok(result);
        }

        [HttpPost("InsertPayment")]
        public IActionResult InsertPayment(Payment payment)
        {
            payment.CreatedAt = DateTime.Now.ToString();
            var id = dataAccess.InsertPayment(payment);
            return Ok(id.ToString());
        }

        [HttpPost("InsertOrder")]
        public IActionResult InsertOrder(Order order)
        {
            order.CreatedAt = DateTime.Now.ToString();
            var id = dataAccess.InsertOrder(order);
            return Ok(id.ToString());
        }

    }
}
