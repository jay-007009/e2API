using Microsoft.EntityFrameworkCore;

namespace RestaurantApp.Models
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext()
        {

        }
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
          : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
         public DbSet<Item> Items { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
    }
}
