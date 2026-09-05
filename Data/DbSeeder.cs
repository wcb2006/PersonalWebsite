using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Models;

namespace PersonalWebsite.Data;

// Seed-datan är innehåll, inte schema. Ligger den i HasData blir den en del av
// modellen, och då kräver varje textändring en ny migration - annars vägrar
// Migrate() att starta. Här synkas den i stället vid uppstart: koden är källan,
// rader som saknas skapas, ändrade rader uppdateras och rader som tagits bort
// ur listorna nedan försvinner ur databasen.
public static class DbSeeder
{
    public static void Seed(AppDbContext db)
    {
        SeedAboutMe(db);
        SeedProjects(db);
        SeedExperiences(db);
        SeedEducations(db);
        SeedCourses(db);
        SeedItExperience(db);

        db.SaveChanges();
    }

    private static void SeedAboutMe(AppDbContext db) => Sync(
        db.AboutMe,
        new List<AboutMe>
        {
            new()
            {
                Id = 1,
                Name = "William Borg",
                Title = "Systemutvecklarstuderande | Säkerhet & IT",
                TitleEn = "Systems Development Student | Security & IT",
                Bio = "Studerande inom systemutveckling med inriktning säkerhet vid JENSEN yrkeshögskola. Arbetar med C#/.NET, SQL och testdriven utveckling, med ett stort intresse för att bygga säkra och hållbara system. Har även erfarenhet från serviceyrken som gett starka färdigheter i teamarbete, kommunikation och att snabbt sätta mig in i nya uppgifter. Drivs av att skapa lösningar som förenklar vardagen och skapar verkligt värde genom teknik.",
                BioEn = "Systems development student specialising in security at JENSEN yrkeshögskola. Works with C#/.NET, SQL and test-driven development, with a strong interest in building secure and maintainable systems. Also brings experience from service roles, which built solid skills in teamwork, communication and picking up new tasks quickly. Motivated by creating solutions that simplify everyday life and deliver real value through technology.",
                GithubUrl = "https://github.com/wcb2006",
                LinkedInUrl = "https://www.linkedin.com/in/williamcborg/"
            }
        },
        a => a.Id,
        (from, to) =>
        {
            to.Name = from.Name;
            to.Title = from.Title;
            to.Bio = from.Bio;
            to.TitleEn = from.TitleEn;
            to.BioEn = from.BioEn;
            to.GithubUrl = from.GithubUrl;
            to.LinkedInUrl = from.LinkedInUrl;
        });

    private static void SeedProjects(AppDbContext db) => Sync(
        db.Projects,
        new List<Project>
        {
            new()
            {
                Id = 1,
                Title = "Personlig hemsida",
                TitleEn = "Personal website",
                Description = "En personlig hemsida byggd med ASP.NET Core MVC och PostgreSQL.",
                DescriptionEn = "A personal website built with ASP.NET Core MVC and PostgreSQL.",
                Technologies = "C#, ASP.NET Core, PostgreSQL, Bootstrap",
                Year = 2026,
                Category = "personal"
            },
            new()
            {
                Id = 2,
                Title = "Fitness App",
                Description = "En webbaserad tränings- och kostapp där man bygger egna träningsprogram, loggar set, reps och vikter samt följer sin viktutveckling över tid.",
                DescriptionEn = "A web-based training and nutrition app where you build your own workout programmes, log sets, reps and weights, and track your weight over time.",
                ImageUrl = "/images/FitnessAppProject.png",
                ProjectUrl = "https://pullpush.jborg.se/",
                Technologies = "C#, ASP.NET Core, PostgreSQL, JavaScript",
                Year = 2026,
                Category = "personal"
            },
            new()
            {
                Id = 3,
                Title = "Spel Hyllan",
                TitleEn = "Game Shelf",
                Description = "En webbaserad applikation där man kan lägga till, redigera och ta bort spel i sin samling. Användare kan även betygsätta spelen",
                DescriptionEn = "A web application for adding, editing and removing games in your collection. Users can also rate the games.",
                ImageUrl = "/images/spelhyllan.png",
                ProjectUrl = "https://spelhyllan-production.up.railway.app",
                Technologies = "JavaScript, Node.js, HTML, CSS, json-server",
                Year = 2026,
                Category = "personal"
            },
            new()
            {
                Id = 4,
                Title = "CoupleSpace",
                Description = "En webbaserad applikation där par kan tillbringa tid tillsammans",
                DescriptionEn = "A web application where couples can spend time together.",
                ImageUrl = "",
                ProjectUrl = "https://web-production-61386.up.railway.app/login",
                Technologies = "C#, TypeScript, .NET, Next.js, PostgreSQL",
                Year = 2026,
                Category = "personal"
            }
        },
        p => p.Id,
        (from, to) =>
        {
            to.Title = from.Title;
            to.TitleEn = from.TitleEn;
            to.Description = from.Description;
            to.DescriptionEn = from.DescriptionEn;
            to.ImageUrl = from.ImageUrl;
            to.ProjectUrl = from.ProjectUrl;
            to.Technologies = from.Technologies;
            to.Year = from.Year;
            to.Category = from.Category;
        });

    private static void SeedExperiences(AppDbContext db) => Sync(
        db.Experiences,
        new List<Experience>
        {
            new()
            {
                Id = 1,
                Company = "Pranari, Malmö",
                Role = "Receptionist",
                RoleEn = "Receptionist",
                StartDate = new DateTime(2025, 12, 1, 0, 0, 0, DateTimeKind.Utc),
                EndDate = null,
                Description = "Administrerade inkommande samtal och dirigerade dem effektivt. Mottog och välkomnade besökare för att skapa ett trevligt intryck.",
                DescriptionEn = "Handled incoming calls and routed them efficiently. Received and welcomed visitors to create a good first impression."
            },
            new()
            {
                Id = 2,
                Company = "Circle K, Malmö",
                Role = "Butiksäljare",
                RoleEn = "Retail sales assistant",
                StartDate = new DateTime(2025, 7, 1, 0, 0, 0, DateTimeKind.Utc),
                EndDate = null,
                Description = "Hanterar kassan och genomför snabba och exakta transaktioner. Utbildar nya medarbetare i försäljningstekniker och kundservice. Skapar och bibehåller en inbjudande och säljande butiksmiljö.",
                DescriptionEn = "Runs the till and completes fast, accurate transactions. Trains new colleagues in sales technique and customer service. Creates and maintains an inviting store environment that drives sales."
            },
            new()
            {
                Id = 3,
                Company = "Region Skåne, Malmö",
                Role = "Vikarie",
                RoleEn = "Temporary staff",
                StartDate = new DateTime(2024, 8, 1, 0, 0, 0, DateTimeKind.Utc),
                EndDate = new DateTime(2025, 6, 30, 0, 0, 0, DateTimeKind.Utc),
                Description = "Databas- och registerhantering. Samordning med olika avdelningar. Hanterar datorer och tekniska system. Effektivt utförande av tilldelade uppgifter.",
                DescriptionEn = "Database and records management. Coordination across departments. Handling of computers and technical systems. Efficient execution of assigned tasks."
            },
            new()
            {
                Id = 4,
                Company = "Region Skåne, Malmö",
                Role = "Sommarpraktikant",
                RoleEn = "Summer intern",
                StartDate = new DateTime(2024, 7, 1, 0, 0, 0, DateTimeKind.Utc),
                EndDate = new DateTime(2024, 8, 31, 0, 0, 0, DateTimeKind.Utc),
                Description = "Effektivt utförande av tilldelade uppgifter.",
                DescriptionEn = "Efficient execution of assigned tasks."
            },
            new()
            {
                Id = 5,
                Company = "Malmö Museum & Tekniska Museum, Malmö",
                Role = "Sommarpraktikant",
                RoleEn = "Summer intern",
                StartDate = new DateTime(2023, 7, 1, 0, 0, 0, DateTimeKind.Utc),
                EndDate = new DateTime(2023, 8, 31, 0, 0, 0, DateTimeKind.Utc),
                Description = "Effektivt utförande av tilldelade uppgifter. Samordnade arbetslag.",
                DescriptionEn = "Efficient execution of assigned tasks. Coordinated work teams."
            }
        },
        e => e.Id,
        (from, to) =>
        {
            to.Company = from.Company;
            to.Role = from.Role;
            to.RoleEn = from.RoleEn;
            to.StartDate = from.StartDate;
            to.EndDate = from.EndDate;
            to.Description = from.Description;
            to.DescriptionEn = from.DescriptionEn;
        });

    private static void SeedEducations(AppDbContext db) => Sync(
        db.Educations,
        new List<Education>
        {
            new()
            {
                Id = 1,
                School = "JENSEN yrkeshögskola",
                Degree = "Systemutvecklare inriktning säkerhet",
                DegreeEn = "Systems Developer, Security Specialisation",
                StartYear = 2025,
                EndYear = null,
                Description = null
            },
            new()
            {
                Id = 2,
                School = "NTI Gymnasiet, Malmö",
                Degree = "Informations- och medieteknik, Teknikprogrammet",
                DegreeEn = "Information and Media Technology, Technology Programme",
                StartYear = 2022,
                EndYear = 2025,
                Description = null
            }
        },
        e => e.Id,
        (from, to) =>
        {
            to.School = from.School;
            to.Degree = from.Degree;
            to.DegreeEn = from.DegreeEn;
            to.StartYear = from.StartYear;
            to.EndYear = from.EndYear;
            to.Description = from.Description;
            to.DescriptionEn = from.DescriptionEn;
        });

    private static void SeedCourses(AppDbContext db) => Sync(
        db.Courses,
        new List<Course>
        {
            new()
            {
                Id = 1,
                Name = "Programmering med C#/.NET, grund",
                NameEn = "Programming with C#/.NET, foundation",
                Description = "Syntax för C#. Hur C# och .NET kan användas för att lösa olika typer av uppgifter. Versionshantering.",
                DescriptionEn = "C# syntax. How C# and .NET are used to solve different kinds of problems. Version control.",
                Grade = "VG",
                StartDate = new DateTime(2025, 8, 18, 0, 0, 0, DateTimeKind.Utc),
                EducationId = 1
            },
            new()
            {
                Id = 2,
                Name = "Självledarskap - att leda sig själv, grund",
                NameEn = "Self-leadership, foundation",
                Description = "Utveckla färdigheter för att motivera sig själv samt attityder som leder till maximal utveckling under studietiden och i arbetslivet. Fokus på ökad anställningsbarhet.",
                DescriptionEn = "Building the skills to motivate yourself and the attitudes that drive maximum development during studies and working life. Focus on increased employability.",
                Grade = "VG",
                StartDate = new DateTime(2025, 8, 11, 0, 0, 0, DateTimeKind.Utc),
                EducationId = 1
            },
            new()
            {
                Id = 3,
                Name = "Databasteknik",
                NameEn = "Database technology",
                Description = "Modellering, lagring och hämtning av data i databaser. SQL, databasdesign och jämförelse av olika databassystem.",
                DescriptionEn = "Modelling, storing and retrieving data in databases. SQL, database design and comparison of different database systems.",
                Grade = "VG",
                StartDate = new DateTime(2025, 10, 20, 0, 0, 0, DateTimeKind.Utc),
                EducationId = 1
            },
            new()
            {
                Id = 4,
                Name = "Testning",
                NameEn = "Testing",
                Description = "Planering, genomförande och uppföljning av tester. Testdriven utveckling (TDD) och olika testmetoder.",
                DescriptionEn = "Planning, running and following up tests. Test-driven development (TDD) and different testing methods.",
                Grade = "VG",
                StartDate = new DateTime(2025, 11, 24, 0, 0, 0, DateTimeKind.Utc),
                EducationId = 1
            },
            new()
            {
                Id = 5,
                Name = "Agil systemutveckling och ämnesövergripande projekt",
                NameEn = "Agile systems development and cross-disciplinary project",
                Description = "Agila metoder, kravhantering, DevOps och projektplanering. Genomförande av ämnesövergripande IT-projekt med fokus på samarbete och agil arbetsmetodik.",
                DescriptionEn = "Agile methods, requirements management, DevOps and project planning. Running a cross-disciplinary IT project with a focus on collaboration and agile ways of working.",
                Grade = "VG",
                StartDate = new DateTime(2026, 1, 5, 0, 0, 0, DateTimeKind.Utc),
                EducationId = 1
            }
        },
        c => c.Id,
        (from, to) =>
        {
            to.Name = from.Name;
            to.NameEn = from.NameEn;
            to.Description = from.Description;
            to.DescriptionEn = from.DescriptionEn;
            to.Grade = from.Grade;
            to.StartDate = from.StartDate;
            to.EducationId = from.EducationId;
        });

    private static void SeedItExperience(AppDbContext db) => Sync(
        db.ItExperience,
        new List<ITExperience>
        {
            new() { Id = 1, Name = "C#" },
            new() { Id = 2, Name = ".NET" },
            new() { Id = 3, Name = "SQL" },
            new() { Id = 4, Name = "Git" },
            new() { Id = 5, Name = "API-utveckling", NameEn = "API development" }
        },
        i => i.Id,
        (from, to) =>
        {
            to.Name = from.Name;
            to.NameEn = from.NameEn;
        });

    private static void Sync<T>(
        DbSet<T> set,
        List<T> wanted,
        Func<T, int> id,
        Action<T, T> copyInto) where T : class
    {
        var existing = set.ToList();

        foreach (var item in wanted)
        {
            var match = existing.FirstOrDefault(e => id(e) == id(item));
            if (match is null)
            {
                set.Add(item);
            }
            else
            {
                copyInto(item, match);
            }
        }

        var wantedIds = wanted.Select(id).ToHashSet();
        set.RemoveRange(existing.Where(e => !wantedIds.Contains(id(e))));
    }
}
