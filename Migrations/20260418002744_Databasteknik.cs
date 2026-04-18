using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalWebsite.Migrations
{
    /// <inheritdoc />
    public partial class Databasteknik : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "EducationId", "Grade", "Name", "StartDate" },
                values: new object[,]
                {
                    { 2, "Utveckla färdigheter för att motivera sig själv samt attityder som leder till maximal utveckling under studietiden och i arbetslivet. Fokus på ökad anställningsbarhet.", 1, "VG", "Självledarskap - att leda sig själv, grund", new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, "Modellering, lagring och hämtning av data i databaser. SQL, databasdesign och jämförelse av olika databassystem.", 1, "VG", "Databasteknik", new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Utc) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
