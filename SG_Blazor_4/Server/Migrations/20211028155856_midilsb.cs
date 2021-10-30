using Microsoft.EntityFrameworkCore.Migrations;

namespace SG_Blazor_4.Server.Migrations
{
    public partial class midilsb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GradoInstruccion",
                table: "ordenAtencions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdOrdenAtencion",
                table: "LSB_50Model",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LSB_50Model_IdOrdenAtencion",
                table: "LSB_50Model",
                column: "IdOrdenAtencion");

            migrationBuilder.AddForeignKey(
                name: "FK_LSB_50Model_ordenAtencions_IdOrdenAtencion",
                table: "LSB_50Model",
                column: "IdOrdenAtencion",
                principalTable: "ordenAtencions",
                principalColumn: "IdOrdenAtencion",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LSB_50Model_ordenAtencions_IdOrdenAtencion",
                table: "LSB_50Model");

            migrationBuilder.DropIndex(
                name: "IX_LSB_50Model_IdOrdenAtencion",
                table: "LSB_50Model");

            migrationBuilder.DropColumn(
                name: "IdOrdenAtencion",
                table: "LSB_50Model");

            migrationBuilder.AlterColumn<string>(
                name: "GradoInstruccion",
                table: "ordenAtencions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
