using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<AppUserCrews>()
        //         .HasOne(a => a.AppUser)
        //         .WithMany(auc => auc.AppUserCrews)
        //         .HasForeignKey(ci => ci.AppUserId);

        //     modelBuilder.Entity<AppUserCrews>()
        //         .HasOne(c => c.Crews )
        //         .WithMany(auc => auc.AppUserCrews)
        //         .HasForeignKey(ci => ci.CrewsId);

        //     modelBuilder.Entity<AppUserCrews>()
        //         .HasMany(c => c.AppUsers)
        //         .WithMany(a => a.Crews)
        //         .UsingEntity(j => j.ToTable("AppUserCrews"));
        // }

        public DbSet<AppUser> AppUsers {get; set;}
        public DbSet<Billables> Billables {get; set;}
        public DbSet<Crews> Crews {get; set;}
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Job> Jobs {get; set;}
        public DbSet<Punch> Punches {get; set;}
        public DbSet<AppUserCrews> AppUserCrews {get; set;}

    }
}