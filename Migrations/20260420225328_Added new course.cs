using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalWebsite.Migrations
{
    /// <inheritdoc />
    public partial class Addednewcourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "EducationId", "Grade", "Name", "StartDate" },
                values: new object[] { 5, "Agila metoder, kravhantering, DevOps och projektplanering. Genomförande av ämnesövergripande IT-projekt med fokus på samarbete och agil arbetsmetodik.", 1, "VG", "Agil systemutveckling och ämnesövergripande projekt", new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Utc) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
