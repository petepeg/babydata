using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BabyData.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<FeedingRecord> FeedingRecords { get; set; }
        public DbSet<SleepRecord> SleepRecords { get; set; }
        public DbSet<Baby> Babies { get; set; }
        public DbSet<DiaperRecord> DiaperRecords { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<DiaperTag> DiaperTags { get; set; }
    }
}
