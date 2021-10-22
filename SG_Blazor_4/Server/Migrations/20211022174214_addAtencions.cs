using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SG_Blazor_4.Server.Migrations
{
    public partial class addAtencions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerPsicoPruebaPsico");

            migrationBuilder.DropTable(
                name: "PerPsico");

            migrationBuilder.DropTable(
                name: "PruebaPsico");

            migrationBuilder.CreateTable(
                name: "atencions",
                columns: table => new
                {
                    IdAtenciones = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Local0 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TipExa = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FecAte = table.Column<DateTime>(type: "date", nullable: true),
                    NomApe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DocIde = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Empres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubCon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Proyec = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Perfil = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Area = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PueTra = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PeReAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Hora = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_atencions", x => x.IdAtenciones);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "atencions");

            migrationBuilder.CreateTable(
                name: "PerPsico",
                columns: table => new
                {
                    IdPerPsico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerPsico", x => x.IdPerPsico);
                });

            migrationBuilder.CreateTable(
                name: "PruebaPsico",
                columns: table => new
                {
                    IdPruebaPsico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PruebaPsico", x => x.IdPruebaPsico);
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
                        name: "FK_PerPsicoPruebaPsico_PerPsico_perPsicosIdPerPsico",
                        column: x => x.perPsicosIdPerPsico,
                        principalTable: "PerPsico",
                        principalColumn: "IdPerPsico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerPsicoPruebaPsico_PruebaPsico_PruebasPsicoIdPruebaPsico",
                        column: x => x.PruebasPsicoIdPruebaPsico,
                        principalTable: "PruebaPsico",
                        principalColumn: "IdPruebaPsico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PruebaPsico",
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
    }
}
