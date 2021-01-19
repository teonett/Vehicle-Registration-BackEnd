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

            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Category>().HasNoKey();
            modelBuilder.Entity<Category>().Property(x => x.Id);
            modelBuilder.Entity<Category>().HasIndex(x => x.Id);
            modelBuilder.Entity<Category>().Property(x => x.Description).HasMaxLength(5).HasColumnType("varchar(5)");
            modelBuilder.Entity<Category>().Ignore(x => x.Vehicles);
            
            modelBuilder.Entity<Vehicle>().ToTable("Vehicle");
            modelBuilder.Entity<Vehicle>().HasNoKey();
            modelBuilder.Entity<Vehicle>().Property(x => x.Id);
            modelBuilder.Entity<Vehicle>().HasIndex(x => x.Id);
            modelBuilder.Entity<Vehicle>().Property(x => x.Description).HasMaxLength(20).HasColumnType("varchar(20)");
            modelBuilder.Entity<Vehicle>().Property(x => x.YearBuild).HasMaxLength(4).HasColumnType("integer(4)");
            modelBuilder.Entity<Vehicle>().Property(x => x.YearCategory).HasMaxLength(4).HasColumnType("integer(4)");
            modelBuilder.Entity<Vehicle>().Property(x => x.CategoryId);
            modelBuilder.Entity<Vehicle>().HasIndex(x => x.CategoryId);

            base.OnModelCreating(modelBuilder);
        }
    }
}