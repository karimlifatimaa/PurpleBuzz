using Microsoft.EntityFrameworkCore;
using Purple_buzz.Models;

namespace Purple_buzz.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Service> Services { get; set; }
        public DbSet<ResentWork> ResentWorks { get; set; }
    }
}
