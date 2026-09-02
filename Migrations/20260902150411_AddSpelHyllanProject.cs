using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalWebsite.Migrations
{
    /// <inheritdoc />
    public partial class AddSpelHyllanProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProjectUrl",
                value: "https://github.com/wcb2006/PersonalWebsite");

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "ProjectUrl", "Technologies", "Title", "Year" },
                values: new object[] { 3, "personal", "En webbaserad applikation där man kan lägga till, redigera och ta bort spel i sin samling. Användare kan även betygsätta spelen", null, "https://spelhyllan-production.up.railway.app", "C#, ASP.NET Core, PostgreSQL, JavaScript", "Spel Hyllan", 2026 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Company", "Description", "EndDate", "Role", "StartDate" },
                values: new object[] { 6, "Pranari, Malmö", "Administrerade inkommande samtal och dirigerade dem effektivt. Mottog och välkomnade besökare för att skapa ett trevligt intryck.", new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), "Receptionist", new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProjectUrl",
                value: null);
        }
    }
}
