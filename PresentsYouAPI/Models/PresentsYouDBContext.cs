using Microsoft.EntityFrameworkCore;

namespace PresentsYouAPI.Models
{
    public class PresentsYouDBContext : DbContext
    {
        public PresentsYouDBContext(DbContextOptions<PresentsYouDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Project> Projects { get; set; } = null!;
        public DbSet<Education> Educations { get; set; } = null!;
        public DbSet<Experience> Experiences { get; set; } = null!;

        public DbSet<Profile> Profiles { get; set; } = null!;
    }
}
