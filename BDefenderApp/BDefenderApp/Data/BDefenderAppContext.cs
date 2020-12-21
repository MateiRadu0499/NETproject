using Microsoft.EntityFrameworkCore;

namespace BDefenderApp.Data
{
    public class BDefenderAppContext : DbContext
    {
        public BDefenderAppContext (DbContextOptions<BDefenderAppContext> options)
            : base(options)
        {
        }

        public DbSet<BDefenderApp.Models.User> User { get; set; }

        public DbSet<BDefenderApp.Models.Login> Login { get; set; }
    }
}
