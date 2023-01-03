using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinemango.Data.Migrations
{
    public partial class InitialMoziSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Felhasznalok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeljesNev = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Felhasznalok", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImdbId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Cim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EredetiCim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KiadasEve = table.Column<int>(type: "int", nullable: false),
                    LeirasHtml = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElozetesUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Boritokep = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JegyTipusok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nev = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JegyTipusok", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Termek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nev = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vasarlasok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Statusz = table.Column<int>(type: "int", nullable: false),
                    FelhasznaloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vasarlasok", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vasarlasok_Felhasznalok_FelhasznaloId",
                        column: x => x.FelhasznaloId,
                        principalTable: "Felhasznalok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ulohelyek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Oldal = table.Column<int>(type: "int", nullable: true),
                    Sor = table.Column<int>(type: "int", nullable: false),
                    Szek = table.Column<int>(type: "int", nullable: false),
                    TeremId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulohelyek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ulohelyek_Termek_TeremId",
                        column: x => x.TeremId,
                        principalTable: "Termek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vetitesek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idopont = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipus = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    TeremId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vetitesek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vetitesek_Filmek_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Filmek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vetitesek_Termek_TeremId",
                        column: x => x.TeremId,
                        principalTable: "Termek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jegyek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ar = table.Column<int>(type: "int", nullable: true),
                    TipusId = table.Column<int>(type: "int", nullable: true),
                    UlohelyId = table.Column<int>(type: "int", nullable: false),
                    VasarlasId = table.Column<int>(type: "int", nullable: true),
                    VetitesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jegyek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jegyek_JegyTipusok_TipusId",
                        column: x => x.TipusId,
                        principalTable: "JegyTipusok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jegyek_Ulohelyek_UlohelyId",
                        column: x => x.UlohelyId,
                        principalTable: "Ulohelyek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jegyek_Vasarlasok_VasarlasId",
                        column: x => x.VasarlasId,
                        principalTable: "Vasarlasok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jegyek_Vetitesek_VetitesId",
                        column: x => x.VetitesId,
                        principalTable: "Vetitesek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmek_ImdbId",
                table: "Filmek",
                column: "ImdbId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jegyek_TipusId",
                table: "Jegyek",
                column: "TipusId");

            migrationBuilder.CreateIndex(
                name: "IX_Jegyek_UlohelyId_VasarlasId",
                table: "Jegyek",
                columns: new[] { "UlohelyId", "VasarlasId" },
                unique: true,
                filter: "[VasarlasId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Jegyek_VasarlasId",
                table: "Jegyek",
                column: "VasarlasId");

            migrationBuilder.CreateIndex(
                name: "IX_Jegyek_VetitesId",
                table: "Jegyek",
                column: "VetitesId");

            migrationBuilder.CreateIndex(
                name: "IX_JegyTipusok_Nev",
                table: "JegyTipusok",
                column: "Nev",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Termek_Nev",
                table: "Termek",
                column: "Nev",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ulohelyek_TeremId_Oldal_Sor_Szek",
                table: "Ulohelyek",
                columns: new[] { "TeremId", "Oldal", "Sor", "Szek" },
                unique: true,
                filter: "[Oldal] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Vasarlasok_FelhasznaloId",
                table: "Vasarlasok",
                column: "FelhasznaloId");

            migrationBuilder.CreateIndex(
                name: "IX_Vetitesek_FilmId",
                table: "Vetitesek",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Vetitesek_TeremId",
                table: "Vetitesek",
                column: "TeremId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jegyek");

            migrationBuilder.DropTable(
                name: "JegyTipusok");

            migrationBuilder.DropTable(
                name: "Ulohelyek");

            migrationBuilder.DropTable(
                name: "Vasarlasok");

            migrationBuilder.DropTable(
                name: "Vetitesek");

            migrationBuilder.DropTable(
                name: "Felhasznalok");

            migrationBuilder.DropTable(
                name: "Filmek");

            migrationBuilder.DropTable(
                name: "Termek");
        }
    }
}
