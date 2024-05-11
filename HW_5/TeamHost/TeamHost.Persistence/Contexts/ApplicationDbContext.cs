using Microsoft.EntityFrameworkCore;
using TeamHost.Domain.Entities;
using TeamHost.Persistence.Configurations;

namespace TeamHost.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<StaticFile> StaticFiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Game> Games { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply the seed data on the tables
            modelBuilder.Entity<Country>().HasData(DatabaseSeeder.Countries());
            modelBuilder.Entity<Platform>().HasData(DatabaseSeeder.Platforms());
            modelBuilder.Entity<Category>().HasData(DatabaseSeeder.Categories());
        }
    }
}
