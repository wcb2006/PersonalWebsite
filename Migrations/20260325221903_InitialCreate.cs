using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalWebsite.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutMe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: false),
                    ProfileImageUrl = table.Column<string>(type: "text", nullable: true),
                    GithubUrl = table.Column<string>(type: "text", nullable: true),
                    LinkedInUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutMe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Subject = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Message = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    SentAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    School = table.Column<string>(type: "text", nullable: false),
                    Degree = table.Column<string>(type: "text", nullable: false),
                    StartYear = table.Column<int>(type: "integer", nullable: false),
                    EndYear = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Company = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    ProjectUrl = table.Column<string>(type: "text", nullable: true),
                    Technologies = table.Column<string>(type: "text", nullable: true),
                    Year = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AboutMe",
                columns: new[] { "Id", "Bio", "GithubUrl", "LinkedInUrl", "Name", "ProfileImageUrl", "Title" },
                values: new object[] { 1, "Driven och mångsidig professionell med erfarenhet inom kundservice och försäljning. Starka färdigheter i kassahantering och teamarbete, med en bakgrund som receptionist och butiksäljare. Utrustad med en utbildning inom systemutveckling och medieteknik, är jag engagerad i att skapa positiva kundupplevelser och effektivt hantera administrativa uppgifter.", "https://github.com/wcb2006", "https://www.linkedin.com/in/williamcborg/", "William Borg", null, "Systemutvecklare" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Degree", "Description", "EndYear", "School", "StartYear" },
                values: new object[,]
                {
                    { 1, "Systemutvecklare inriktning säkerhet", null, null, "JENSEN yrkeshögskola", 2025 },
                    { 2, "Informations- och medieteknik, Teknikprogrammet", null, 2025, "NTI Gymnasiet, Malmö", 2022 }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Company", "Description", "EndDate", "Role", "StartDate" },
                values: new object[,]
                {
                    { 1, "Pranari, Malmö", "Administrerade inkommande samtal och dirigerade dem effektivt. Mottog och välkomnade besökare för att skapa ett trevligt intryck.", null, "Receptionist", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2, "Circle K, Malmö", "Hanterar kassan och genomför snabba och exakta transaktioner. Utbildar nya medarbetare i försäljningstekniker och kundservice. Skapar och bibehåller en inbjudande och säljande butiksmiljö.", null, "Butiksäljare", new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, "Region Skåne, Malmö", "Databas- och registerhantering. Samordning med olika avdelningar. Hanterar datorer och tekniska system. Effektivt utförande av tilldelade uppgifter.", new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Vikarie", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, "Region Skåne, Malmö", "Effektivt utförande av tilldelade uppgifter.", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Utc), "Sommarpraktikant", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, "Malmö Museum & Tekniska Museum, Malmö", "Effektivt utförande av tilldelade uppgifter. Samordnade arbetslag.", new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Utc), "Sommarpraktikant", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, "Pranari, Malmö", "Administrerade inkommande samtal och dirigerade dem effektivt. Mottog och välkomnade besökare för att skapa ett trevligt intryck.", new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), "Receptionist", new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "ImageUrl", "ProjectUrl", "Technologies", "Title", "Year" },
                values: new object[] { 1, "En personlig hemsida byggd med ASP.NET Core MVC och PostgreSQL.", null, null, "C#, ASP.NET Core, PostgreSQL, Bootstrap", "Personlig hemsida", 2026 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutMe");

            migrationBuilder.DropTable(
                name: "ContactMessages");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
