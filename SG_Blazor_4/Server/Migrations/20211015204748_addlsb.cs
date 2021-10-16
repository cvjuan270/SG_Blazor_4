using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SG_Blazor_4.Server.Migrations
{
    public partial class addlsb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LSB_50Model");
        }
    }
}
