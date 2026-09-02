using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalWebsite.Migrations
{
    /// <inheritdoc />
    public partial class CoupleSpacePlaceholderImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/couplespace.png");
        }
    }
}
