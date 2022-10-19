namespace e2API.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public Book Book { get; set; } = new Book();
    }
}
