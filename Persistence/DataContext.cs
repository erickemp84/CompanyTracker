using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers {get; set;}
        public DbSet<Billables> Billables {get; set;}
        public DbSet<Crews> Crews {get; set;}
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Job> Jobs {get; set;}
        public DbSet<Punch> Punches {get; set;}
        public DbSet<AppUserCrews> AppUserCrews {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUserCrews>(x => x.HasKey(ac => new {ac.AppUserId, ac.CrewsId}));

            builder.Entity<AppUserCrews>()
                .HasOne(u => u.AppUser)
                .WithMany(c => c.Crews)
                .HasForeignKey(ac => ac.AppUserId);

            builder.Entity<AppUserCrews>()
                .HasOne(u => u.Crews)
                .WithMany(c => c.AppUsers)
                .HasForeignKey(ac => ac.CrewsId);
        }

    }
}

