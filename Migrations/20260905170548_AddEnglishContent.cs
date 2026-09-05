using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalWebsite.Migrations
{
    /// <inheritdoc />
    public partial class AddEnglishContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Projects",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleEn",
                table: "Projects",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "ItExperience",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Experiences",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoleEn",
                table: "Experiences",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DegreeEn",
                table: "Educations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Educations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Courses",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "Courses",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BioEn",
                table: "AboutMe",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleEn",
                table: "AboutMe",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TitleEn",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "ItExperience");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "RoleEn",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "DegreeEn",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "BioEn",
                table: "AboutMe");

            migrationBuilder.DropColumn(
                name: "TitleEn",
                table: "AboutMe");
        }
    }
}
