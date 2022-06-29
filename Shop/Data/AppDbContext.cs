using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<GameShop> GameShops { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
