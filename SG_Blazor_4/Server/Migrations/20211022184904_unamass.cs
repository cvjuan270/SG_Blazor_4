using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SG_Blazor_4.Server.Migrations
{
    public partial class unamass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "atencions");

            migrationBuilder.AddColumn<int>(
                name: "IdOrdenAtencion",
                table: "Ba7Models",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ordenAtencions",
                columns: table => new
                {
                    IdOrdenAtencion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dni = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    NomApe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GradoInstruccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordenAtencions", x => x.IdOrdenAtencion);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ba7Models_IdOrdenAtencion",
                table: "Ba7Models",
                column: "IdOrdenAtencion");

            migrationBuilder.AddForeignKey(
                name: "FK_Ba7Models_ordenAtencions_IdOrdenAtencion",
                table: "Ba7Models",
                column: "IdOrdenAtencion",
                principalTable: "ordenAtencions",
                principalColumn: "IdOrdenAtencion",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ba7Models_ordenAtencions_IdOrdenAtencion",
                table: "Ba7Models");

            migrationBuilder.DropTable(
                name: "ordenAtencions");

            migrationBuilder.DropIndex(
                name: "IX_Ba7Models_IdOrdenAtencion",
                table: "Ba7Models");

            migrationBuilder.DropColumn(
                name: "IdOrdenAtencion",
                table: "Ba7Models");

            migrationBuilder.CreateTable(
                name: "atencions",
                columns: table => new
                {
                    IdAtenciones = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DocIde = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Empres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FecAte = table.Column<DateTime>(type: "date", nullable: true),
                    Hora = table.Column<TimeSpan>(type: "time", nullable: true),
                    Local0 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NomApe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PeReAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Perfil = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Proyec = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PueTra = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubCon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TipExa = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_atencions", x => x.IdAtenciones);
                });
        }
    }
}
