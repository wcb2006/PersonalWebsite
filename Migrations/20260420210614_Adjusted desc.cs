using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalWebsite.Migrations
{
    /// <inheritdoc />
    public partial class Adjusteddesc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "Title" },
                values: new object[] { "Studerande inom systemutveckling med inriktning säkerhet vid JENSEN yrkeshögskola. Arbetar med C#/.NET, SQL och testdriven utveckling, med ett stort intresse för att bygga säkra och hållbara system. Har även erfarenhet från serviceyrken som gett starka färdigheter i teamarbete, kommunikation och att snabbt sätta mig in i nya uppgifter. Drivs av att skapa lösningar som förenklar vardagen och skapar verkligt värde genom teknik.", "Systemutvecklarstuderande | Säkerhet & IT" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "Title" },
                values: new object[] { "Driven och mångsidig professionell med erfarenhet inom kundservice och försäljning. Starka färdigheter i kassahantering och teamarbete, med en bakgrund som receptionist och butiksäljare. Utrustad med en utbildning inom systemutveckling och medieteknik, är jag engagerad i att skapa positiva kundupplevelser och effektivt hantera administrativa uppgifter.", "Systemutvecklare" });
        }
    }
}
