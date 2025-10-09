using Microsoft.EntityFrameworkCore;

namespace Day06_LamThem.Entities
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        { 
        
        }
        public DbSet<Day06_LamThem.Models.Category> Categories { get; set; }
        public DbSet<Day06_LamThem.Models.Product> Products { get; set; }
    }
}
