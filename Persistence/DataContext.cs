using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext 
    {

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUserCrews>().HasKey(a => new {a.AppUserId, a.CrewsId});

            modelBuilder.Entity<AppUserCrews>()
                .HasOne<AppUser>(a => a.AppUser)
                .WithMany(a => a.AppUserCrews)
                .HasForeignKey(a => a.AppUserId);

            modelBuilder.Entity<AppUserCrews>()
                .HasOne<Crews>(a => a.Crews)
                .WithMany(a => a.AppUserCrews)
                .HasForeignKey(a => a.CrewsId);
        }

        public DbSet<AppUser> AppUsers {get; set;}
        public DbSet<Billables> Billables {get; set;}
        public DbSet<Crews> Crews {get; set;}
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Job> Jobs {get; set;}
        public DbSet<Punch> Punches {get; set;}
        public DbSet<AppUserCrews> AppUserCrews {get; set;}

    }
}