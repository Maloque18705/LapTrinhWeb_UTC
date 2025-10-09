using Microsoft.EntityFrameworkCore;
using Day07_HandOn.Models;

namespace Day07_HandOn.Entities
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
