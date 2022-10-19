namespace e2API.Models
{
    public class Review
    {
        public int Id { get; set; }
        public User User { get; set; } = new User();
        public Book Book { get; set; } = new Book();
        public string Value { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
    }
}
