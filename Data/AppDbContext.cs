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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AboutMe>().HasData(new AboutMe
        {
            Id = 1,
            Name = "William Borg",
            Title = "Systemutvecklare",
            Bio = "Driven och mångsidig professionell med erfarenhet inom kundservice och försäljning. " +
                  "Starka färdigheter i kassahantering och teamarbete, med en bakgrund som receptionist " +
                  "och butiksäljare. Utrustad med en utbildning inom systemutveckling och medieteknik, är " +
                  "jag engagerad i att skapa positiva kundupplevelser och effektivt hantera administrativa uppgifter.",
            GithubUrl = "https://github.com/wcb2006",
            LinkedInUrl = "https://www.linkedin.com/in/williamcborg/"
        });

        modelBuilder.Entity<Project>().HasData(
            new Project
            {
                Id = 1,
                Title = "Personlig hemsida",
                Description = "En personlig hemsida byggd med ASP.NET Core MVC och PostgreSQL.",
                Technologies = "C#, ASP.NET Core, PostgreSQL, Bootstrap",
                Year = 2026
            }
        );

        modelBuilder.Entity<Experience>().HasData(
            new Experience
            {
                Id = 1,
                Company = "Pranari, Malmö",
                Role = "Receptionist",
                StartDate = new DateTime(2025, 12, 1, 0, 0, 0, DateTimeKind.Utc),
                EndDate = null,
                Description = "Administrerade inkommande samtal och dirigerade dem effektivt. Mottog och välkomnade besökare för att skapa ett trevligt intryck."
            },
            new Experience
            {
                Id = 2,
                Company = "Circle K, Malmö",
                Role = "Butiksäljare",
                StartDate = new DateTime(2025, 7, 1, 0, 0, 0, DateTimeKind.Utc),
                EndDate = null,
                Description = "Hanterar kassan och genomför snabba och exakta transaktioner. Utbildar nya medarbetare i försäljningstekniker och kundservice. Skapar och bibehåller en inbjudande och säljande butiksmiljö."
            },
            new Experience
            {
                Id = 3,
                Company = "Region Skåne, Malmö",
                Role = "Vikarie",
                StartDate = new DateTime(2024, 8, 1, 0, 0, 0, DateTimeKind.Utc),
                EndDate = new DateTime(2025, 6, 30, 0, 0, 0, DateTimeKind.Utc),
                Description = "Databas- och registerhantering. Samordning med olika avdelningar. Hanterar datorer och tekniska system. Effektivt utförande av tilldelade uppgifter."
            },
            new Experience
            {
                Id = 4,
                Company = "Region Skåne, Malmö",
                Role = "Sommarpraktikant",
                StartDate = new DateTime(2024, 7, 1, 0, 0, 0, DateTimeKind.Utc),
                EndDate = new DateTime(2024, 8, 31, 0, 0, 0, DateTimeKind.Utc),
                Description = "Effektivt utförande av tilldelade uppgifter."
            },
            new Experience
            {
                Id = 5,
                Company = "Malmö Museum & Tekniska Museum, Malmö",
                Role = "Sommarpraktikant",
                StartDate = new DateTime(2023, 7, 1, 0, 0, 0, DateTimeKind.Utc),
                EndDate = new DateTime(2023, 8, 31, 0, 0, 0, DateTimeKind.Utc),
                Description = "Effektivt utförande av tilldelade uppgifter. Samordnade arbetslag."
            },
            new Experience
            {
                Id = 6,
                Company = "Pranari, Malmö",
                Role = "Receptionist",
                StartDate = new DateTime(2020, 8, 1, 0, 0, 0, DateTimeKind.Utc),
                EndDate = new DateTime(2021, 3, 31, 0, 0, 0, DateTimeKind.Utc),
                Description = "Administrerade inkommande samtal och dirigerade dem effektivt. Mottog och välkomnade besökare för att skapa ett trevligt intryck."
            }
        );

        modelBuilder.Entity<Course>().HasData(
            new Course
            {
                Id = 1,
                Name = "Programmering med C#/.NET, grund",
                Description = "Syntax för C#. Hur C# och .NET kan användas för att lösa olika typer av uppgifter. Versionshantering.",
                Grade = "VG",
                StartDate = new DateTime(2025, 8, 18, 0, 0, 0, DateTimeKind.Utc),
                EducationId = 1
            },
            new Course
            {
                Id = 2,
                Name = "Självledarskap - att leda sig själv, grund",
                Description = "Utveckla färdigheter för att motivera sig själv samt attityder som leder till maximal utveckling under studietiden och i arbetslivet. Fokus på ökad anställningsbarhet.",
                Grade = "VG",
                StartDate = new DateTime(2025, 8, 11, 0, 0, 0, DateTimeKind.Utc),
                EducationId = 1
            },
            new Course
            {
                Id = 3,
                Name = "Databasteknik",
                Description = "Modellering, lagring och hämtning av data i databaser. SQL, databasdesign och jämförelse av olika databassystem.",
                Grade = "VG",
                StartDate = new DateTime(2025, 10, 20, 0, 0, 0, DateTimeKind.Utc),
                EducationId = 1
            }
        );



        modelBuilder.Entity<Education>().HasData(
            new Education
            {
                Id = 1,
                School = "JENSEN yrkeshögskola",
                Degree = "Systemutvecklare inriktning säkerhet",
                StartYear = 2025,
                EndYear = null,
                Description = null
            },
            new Education
            {
                Id = 2,
                School = "NTI Gymnasiet, Malmö",
                Degree = "Informations- och medieteknik, Teknikprogrammet",
                StartYear = 2022,
                EndYear = 2025,
                Description = null
            }
        );
    }
}
