using Microsoft.EntityFrameworkCore.Migrations;

namespace SG_Blazor_4.Server.Migrations
{
    public partial class unamas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Perfil",
                table: "ordenAtencions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "ordenAtencions");
        }
    }
}
