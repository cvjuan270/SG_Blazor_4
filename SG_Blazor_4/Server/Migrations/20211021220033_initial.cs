using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SG_Blazor_4.Server.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ba7Models",
                columns: table => new
                {
                    IdBa7 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _1 = table.Column<int>(type: "int", nullable: false),
                    _2 = table.Column<int>(type: "int", nullable: false),
                    _3 = table.Column<int>(type: "int", nullable: false),
                    _4 = table.Column<int>(type: "int", nullable: false),
                    _5 = table.Column<int>(type: "int", nullable: false),
                    _6 = table.Column<int>(type: "int", nullable: false),
                    _7 = table.Column<int>(type: "int", nullable: false),
                    _8 = table.Column<int>(type: "int", nullable: false),
                    _9 = table.Column<int>(type: "int", nullable: false),
                    _10 = table.Column<int>(type: "int", nullable: false),
                    _11 = table.Column<int>(type: "int", nullable: false),
                    _12 = table.Column<int>(type: "int", nullable: false),
                    _13 = table.Column<int>(type: "int", nullable: false),
                    _14 = table.Column<int>(type: "int", nullable: false),
                    _15 = table.Column<int>(type: "int", nullable: false),
                    _16 = table.Column<int>(type: "int", nullable: false),
                    _17 = table.Column<int>(type: "int", nullable: false),
                    _18 = table.Column<int>(type: "int", nullable: false),
                    _19 = table.Column<int>(type: "int", nullable: false),
                    _20 = table.Column<int>(type: "int", nullable: false),
                    _21 = table.Column<int>(type: "int", nullable: false),
                    _22 = table.Column<int>(type: "int", nullable: false),
                    _23 = table.Column<int>(type: "int", nullable: false),
                    _24 = table.Column<int>(type: "int", nullable: false),
                    _25 = table.Column<int>(type: "int", nullable: false),
                    _26 = table.Column<int>(type: "int", nullable: false),
                    _27 = table.Column<int>(type: "int", nullable: false),
                    _28 = table.Column<int>(type: "int", nullable: false),
                    _29 = table.Column<int>(type: "int", nullable: false),
                    _30 = table.Column<int>(type: "int", nullable: false),
                    _31 = table.Column<int>(type: "int", nullable: false),
                    _32 = table.Column<int>(type: "int", nullable: false),
                    _33 = table.Column<int>(type: "int", nullable: false),
                    _34 = table.Column<int>(type: "int", nullable: false),
                    _35 = table.Column<int>(type: "int", nullable: false),
                    _36 = table.Column<int>(type: "int", nullable: false),
                    _37 = table.Column<int>(type: "int", nullable: false),
                    _38 = table.Column<int>(type: "int", nullable: false),
                    _39 = table.Column<int>(type: "int", nullable: false),
                    _40 = table.Column<int>(type: "int", nullable: false),
                    _41 = table.Column<int>(type: "int", nullable: false),
                    _42 = table.Column<int>(type: "int", nullable: false),
                    _43 = table.Column<int>(type: "int", nullable: false),
                    _44 = table.Column<int>(type: "int", nullable: false),
                    _45 = table.Column<int>(type: "int", nullable: false),
                    _46 = table.Column<int>(type: "int", nullable: false),
                    _47 = table.Column<int>(type: "int", nullable: false),
                    _48 = table.Column<int>(type: "int", nullable: false),
                    _49 = table.Column<int>(type: "int", nullable: false),
                    _50 = table.Column<int>(type: "int", nullable: false),
                    _51 = table.Column<int>(type: "int", nullable: false),
                    _52 = table.Column<int>(type: "int", nullable: false),
                    _53 = table.Column<int>(type: "int", nullable: false),
                    _54 = table.Column<int>(type: "int", nullable: false),
                    _55 = table.Column<int>(type: "int", nullable: false),
                    _56 = table.Column<int>(type: "int", nullable: false),
                    _57 = table.Column<int>(type: "int", nullable: false),
                    _58 = table.Column<int>(type: "int", nullable: false),
                    _59 = table.Column<int>(type: "int", nullable: false),
                    _60 = table.Column<int>(type: "int", nullable: false),
                    _61 = table.Column<int>(type: "int", nullable: false),
                    _62 = table.Column<int>(type: "int", nullable: false),
                    _63 = table.Column<int>(type: "int", nullable: false),
                    _64 = table.Column<int>(type: "int", nullable: false),
                    _65 = table.Column<int>(type: "int", nullable: false),
                    _66 = table.Column<int>(type: "int", nullable: false),
                    _67 = table.Column<int>(type: "int", nullable: false),
                    _68 = table.Column<int>(type: "int", nullable: false),
                    _69 = table.Column<int>(type: "int", nullable: false),
                    _70 = table.Column<int>(type: "int", nullable: false),
                    _71 = table.Column<int>(type: "int", nullable: false),
                    _72 = table.Column<int>(type: "int", nullable: false),
                    _73 = table.Column<int>(type: "int", nullable: false),
                    _74 = table.Column<int>(type: "int", nullable: false),
                    _75 = table.Column<int>(type: "int", nullable: false),
                    _76 = table.Column<int>(type: "int", nullable: false),
                    _77 = table.Column<int>(type: "int", nullable: false),
                    _78 = table.Column<int>(type: "int", nullable: false),
                    _79 = table.Column<int>(type: "int", nullable: false),
                    _80 = table.Column<int>(type: "int", nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    NomApe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GradoInstruccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ba7Models", x => x.IdBa7);
                });

            migrationBuilder.CreateTable(
                name: "LSB_50Model",
                columns: table => new
                {
                    IdLSB_50 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _1 = table.Column<int>(type: "int", nullable: false),
                    _2 = table.Column<int>(type: "int", nullable: false),
                    _3 = table.Column<int>(type: "int", nullable: false),
                    _4 = table.Column<int>(type: "int", nullable: false),
                    _5 = table.Column<int>(type: "int", nullable: false),
                    _6 = table.Column<int>(type: "int", nullable: false),
                    _7 = table.Column<int>(type: "int", nullable: false),
                    _8 = table.Column<int>(type: "int", nullable: false),
                    _9 = table.Column<int>(type: "int", nullable: false),
                    _10 = table.Column<int>(type: "int", nullable: false),
                    _11 = table.Column<int>(type: "int", nullable: false),
                    _12 = table.Column<int>(type: "int", nullable: false),
                    _13 = table.Column<int>(type: "int", nullable: false),
                    _14 = table.Column<int>(type: "int", nullable: false),
                    _15 = table.Column<int>(type: "int", nullable: false),
                    _16 = table.Column<int>(type: "int", nullable: false),
                    _17 = table.Column<int>(type: "int", nullable: false),
                    _18 = table.Column<int>(type: "int", nullable: false),
                    _19 = table.Column<int>(type: "int", nullable: false),
                    _20 = table.Column<int>(type: "int", nullable: false),
                    _21 = table.Column<int>(type: "int", nullable: false),
                    _22 = table.Column<int>(type: "int", nullable: false),
                    _23 = table.Column<int>(type: "int", nullable: false),
                    _24 = table.Column<int>(type: "int", nullable: false),
                    _25 = table.Column<int>(type: "int", nullable: false),
                    _26 = table.Column<int>(type: "int", nullable: false),
                    _27 = table.Column<int>(type: "int", nullable: false),
                    _28 = table.Column<int>(type: "int", nullable: false),
                    _29 = table.Column<int>(type: "int", nullable: false),
                    _30 = table.Column<int>(type: "int", nullable: false),
                    _31 = table.Column<int>(type: "int", nullable: false),
                    _32 = table.Column<int>(type: "int", nullable: false),
                    _33 = table.Column<int>(type: "int", nullable: false),
                    _34 = table.Column<int>(type: "int", nullable: false),
                    _35 = table.Column<int>(type: "int", nullable: false),
                    _36 = table.Column<int>(type: "int", nullable: false),
                    _37 = table.Column<int>(type: "int", nullable: false),
                    _38 = table.Column<int>(type: "int", nullable: false),
                    _39 = table.Column<int>(type: "int", nullable: false),
                    _40 = table.Column<int>(type: "int", nullable: false),
                    _41 = table.Column<int>(type: "int", nullable: false),
                    _42 = table.Column<int>(type: "int", nullable: false),
                    _43 = table.Column<int>(type: "int", nullable: false),
                    _44 = table.Column<int>(type: "int", nullable: false),
                    _45 = table.Column<int>(type: "int", nullable: false),
                    _46 = table.Column<int>(type: "int", nullable: false),
                    _47 = table.Column<int>(type: "int", nullable: false),
                    _48 = table.Column<int>(type: "int", nullable: false),
                    _49 = table.Column<int>(type: "int", nullable: false),
                    _50 = table.Column<int>(type: "int", nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    NomApe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GradoInstruccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LSB_50Model", x => x.IdLSB_50);
                });

            migrationBuilder.CreateTable(
                name: "perPsicos",
                columns: table => new
                {
                    IdPerPsico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perPsicos", x => x.IdPerPsico);
                });

            migrationBuilder.CreateTable(
                name: "pruebaPsicos",
                columns: table => new
                {
                    IdPruebaPsico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pruebaPsicos", x => x.IdPruebaPsico);
                });

            migrationBuilder.CreateTable(
                name: "PerPsicoPruebaPsico",
                columns: table => new
                {
                    PruebasPsicoIdPruebaPsico = table.Column<int>(type: "int", nullable: false),
                    perPsicosIdPerPsico = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerPsicoPruebaPsico", x => new { x.PruebasPsicoIdPruebaPsico, x.perPsicosIdPerPsico });
                    table.ForeignKey(
                        name: "FK_PerPsicoPruebaPsico_perPsicos_perPsicosIdPerPsico",
                        column: x => x.perPsicosIdPerPsico,
                        principalTable: "perPsicos",
                        principalColumn: "IdPerPsico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerPsicoPruebaPsico_pruebaPsicos_PruebasPsicoIdPruebaPsico",
                        column: x => x.PruebasPsicoIdPruebaPsico,
                        principalTable: "pruebaPsicos",
                        principalColumn: "IdPruebaPsico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "pruebaPsicos",
                columns: new[] { "IdPruebaPsico", "Nombre" },
                values: new object[,]
                {
                    { 1, "DISC" },
                    { 2, "Test de Lucher" },
                    { 3, "IG2 - Tony 2" },
                    { 4, "Cuestionario de persepción del riesgo" },
                    { 5, "BA7-A (Atención y consentración)" },
                    { 6, "LSB-50 (Minimult)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PerPsicoPruebaPsico_perPsicosIdPerPsico",
                table: "PerPsicoPruebaPsico",
                column: "perPsicosIdPerPsico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ba7Models");

            migrationBuilder.DropTable(
                name: "LSB_50Model");

            migrationBuilder.DropTable(
                name: "PerPsicoPruebaPsico");

            migrationBuilder.DropTable(
                name: "perPsicos");

            migrationBuilder.DropTable(
                name: "pruebaPsicos");
        }
    }
}
