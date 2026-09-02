using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Models;

namespace PersonalWebsite.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<AboutMe> AboutMe { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<ContactMessage> ContactMessages { get; set; }
    public DbSet<ITExperience> ItExperience { get; set; }

    // Innehållet ligger i DbSeeder och synkas vid uppstart, inte via HasData.
}
