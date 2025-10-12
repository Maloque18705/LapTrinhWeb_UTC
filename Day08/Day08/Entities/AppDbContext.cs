using Day08.Models;
using Microsoft.EntityFrameworkCore;

namespace Day08.Entities
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<QUAN_TRI> QUAN_TRIs { get; set; }
        public DbSet<KHACH_HANG> KHACH_HANGs { get; set; }
        public DbSet<LOAI_SAN_PHAM> LOAI_SAN_PHAMs { get; set; }
        public DbSet<SAN_PHAM> SAN_PHAMs { get; set; }
        public DbSet<HOA_DON> HOA_DONs { get; set; }
        public DbSet<CT_HOA_DON> CT_HOA_DONs { get; set; }
    }
}
