using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalWebsite.Migrations
{
    /// <inheritdoc />
    public partial class AddFitnessAppProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Körs idempotent: databasen kan redan innehålla ett manuellt tillagt
            // Fitness App-projekt (t.ex. i produktion), och då ska raden bara rättas
            // till istället för att en dubblett läggs in.
            migrationBuilder.Sql(@"
                UPDATE ""Projects""
                SET ""ImageUrl"" = '/images/FitnessAppProject.png',
                    ""ProjectUrl"" = 'https://pullpush.jborg.se/',
                    ""Category"" = 'personal'
                WHERE ""Title"" ILIKE '%fitness%';

                INSERT INTO ""Projects"" (""Id"", ""Title"", ""Description"", ""ImageUrl"", ""ProjectUrl"", ""Technologies"", ""Year"", ""Category"")
                SELECT 2,
                       'Fitness App',
                       'En webbaserad tränings- och kostapp där man bygger egna träningsprogram, loggar set, reps och vikter samt följer sin viktutveckling över tid.',
                       '/images/FitnessAppProject.png',
                       'https://pullpush.jborg.se/',
                       'C#, ASP.NET Core, PostgreSQL, JavaScript',
                       2026,
                       'personal'
                WHERE NOT EXISTS (SELECT 1 FROM ""Projects"" WHERE ""Title"" ILIKE '%fitness%')
                  AND NOT EXISTS (SELECT 1 FROM ""Projects"" WHERE ""Id"" = 2);

                -- Projekt utan kategori syns annars varken under 'Mina projekt' eller 'Skolprojekt'.
                UPDATE ""Projects"" SET ""Category"" = 'personal' WHERE ""Category"" IS NULL;

                SELECT setval(
                    pg_get_serial_sequence('""Projects""', 'Id'),
                    GREATEST((SELECT MAX(""Id"") FROM ""Projects""), 1));
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
