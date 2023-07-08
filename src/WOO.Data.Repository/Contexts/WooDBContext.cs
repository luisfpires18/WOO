namespace WOO.Data.Repository.Contexts
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using WOO.Data.Repository.Model;

    public class WooDBContext : IdentityDbContext
    {
        public WooDBContext(DbContextOptions<WooDBContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
    }
}