using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : IdentityDbContext<AppUserCrew>
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
        public Dbset<AppUserCrews> AppUserCrews {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUserCrew>(x => x.HasKey(ac => new {ac.AppUserId, ac.CrewsId}));

            builder.Entity<AppUserCrew>()
                .HasOne(u => u.AppUser)
                .WithMany(c => c.Crews)
                .HasForeignKey(ac => ac.AppUserId);

            builder.Entity<AppUserCrews>()
                .Hasone(u => u.Crews)
                .WithMany(c => c.Appusers)
                .HasForeignKey(ac => ac.CrewsId);
        }

    }
}