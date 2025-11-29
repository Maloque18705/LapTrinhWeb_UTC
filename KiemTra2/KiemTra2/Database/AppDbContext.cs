using Microsoft.EntityFrameworkCore;
using KiemTra2.Models;

namespace KiemTra2.Database
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
           
    }
}
