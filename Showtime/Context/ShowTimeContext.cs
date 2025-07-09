using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Showtime.Entities;

namespace Showtime.Context
{
    public class ShowTimeContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ShowTimeContext(DbContextOptions<ShowTimeContext> options) : base(options) { }

        public DbSet<Band> Bands { get; set; }
      
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public DbSet<FestivalBand> FestivalBands { get; set; }
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FestivalBand>()
                .HasKey(fb => new { fb.FestivalId, fb.BandId });

            modelBuilder.Entity<FestivalBand>()
                .HasOne(fb => fb.Festival)
                .WithMany(b => b.FestivalBands)
                .HasForeignKey(fb => fb.FestivalId);


            modelBuilder.Entity<FestivalBand>()
                .HasOne(fb => fb.Band)
                .WithMany(b => b.FestivalBands)
                .HasForeignKey(fb => fb.BandId);

            base.OnModelCreating(modelBuilder);

        }
    }
}
