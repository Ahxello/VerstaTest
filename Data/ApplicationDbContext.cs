using Microsoft.EntityFrameworkCore;
using VerstaTest.Models;

namespace VerstaTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
    }
}
