using BE_Vehicle.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BE_Vehicle.Infra.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            
        }

        public DbSet<Category> Categories {get; set;}
        public DbSet<Vehicle> Vehicles {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasKey(x => x.Id);
            modelBuilder.Entity<Vehicle>().HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}