using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalWebsite.Migrations
{
    /// <summary>
    /// Seed-datan har flyttats från AppDbContext.HasData till DbSeeder, som
    /// synkar innehållet vid uppstart. Migrationen finns bara för att hålla
    /// modellsnapshotet i takt med modellen.
    ///
    /// Den är medvetet tom: EF scaffoldade DeleteData för varje seedad rad,
    /// men de raderna ska ligga kvar. DbSeeder äger dem efter det här och
    /// uppdaterar dem på plats.
    /// </summary>
    public partial class MoveSeedDataOutOfModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
