using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalWebsite.Migrations
{
    /// <inheritdoc />
    public partial class AddCoupleSpaceProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "ProjectUrl", "Technologies", "Title", "Year" },
                values: new object[] { 4, "personal", "En webbaserad applikation där par kan skapa en gemensam", "/images/couplespace.png", "https://web-production-61386.up.railway.app/login", "C#, TypeScript, .NET, Next.js, PostgreSQL", "CoupleSpace", 2026 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
