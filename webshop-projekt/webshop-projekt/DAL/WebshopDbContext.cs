using webshop_projekt.Models;
using Microsoft.EntityFrameworkCore;

namespace webshop_projekt.DAL
{
    public class WebshopDbContext : DbContext
    {
        public WebshopDbContext(DbContextOptions<WebshopDbContext> options) : base(options)
        { }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
