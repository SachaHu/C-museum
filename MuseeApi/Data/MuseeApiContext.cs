using Microsoft.EntityFrameworkCore;
using MuseeApi.Models;

namespace MuseeApi.Data
{
    public class MuseeApiContext : DbContext
    {
        public MuseeApiContext(DbContextOptions<MuseeApiContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Area>().HasMany<Slot>(a => a.Slots)
                .WithOne(s => s.Area).HasForeignKey(s => s.SlotId)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Slot>().HasMany<Exhibit>(s => s.Exhibits)
                .WithOne(e => e.Slot).HasForeignKey(e => e.SlotId)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<ActivityTag>().HasKey(at => new { at.ActivityId, at.TagId });
            modelBuilder.Entity<ExhibitTag>().HasKey(et => new { et.ExhibitId, et.TagId });
            modelBuilder.Entity<AreaActivity>().HasKey(aa => new { aa.AreaId, aa.ActivityId });
            modelBuilder.Entity<UserActivity>().HasKey(ua => new { ua.UserId, ua.ActivityId });

        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Exhibit> Exhibits { get; set; }
        public DbSet<ActivityTag> ActivityTags { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ExhibitTag> ExhibitTags { get; set; }
        public DbSet<AreaActivity> AreaActivities { get; set; }
        public DbSet<UserActivity> UserActivities { get; set; }
        public DbSet<User> Users { get; set; }

    }
}