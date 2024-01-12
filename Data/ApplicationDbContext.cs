using Microsoft.EntityFrameworkCore;

namespace VerstaTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                Database.EnsureCreated();
        }
    }
}
