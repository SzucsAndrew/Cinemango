using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinemango.Data.Migrations
{
    public partial class JegyUniqueIndexFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Jegyek_UlohelyId_VasarlasId",
                table: "Jegyek");

            migrationBuilder.CreateIndex(
                name: "IX_Jegyek_UlohelyId_VetitesId",
                table: "Jegyek",
                columns: new[] { "UlohelyId", "VetitesId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Jegyek_UlohelyId_VetitesId",
                table: "Jegyek");

            migrationBuilder.CreateIndex(
                name: "IX_Jegyek_UlohelyId_VasarlasId",
                table: "Jegyek",
                columns: new[] { "UlohelyId", "VasarlasId" },
                unique: true,
                filter: "[VasarlasId] IS NOT NULL");
        }
    }
}
