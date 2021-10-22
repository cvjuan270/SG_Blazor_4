using Microsoft.EntityFrameworkCore.Migrations;

namespace SG_Blazor_4.Server.Migrations
{
    public partial class deleteroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerPsicoPruebaPsico_perPsicos_perPsicosIdPerPsico",
                table: "PerPsicoPruebaPsico");

            migrationBuilder.DropForeignKey(
                name: "FK_PerPsicoPruebaPsico_pruebaPsicos_PruebasPsicoIdPruebaPsico",
                table: "PerPsicoPruebaPsico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pruebaPsicos",
                table: "pruebaPsicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_perPsicos",
                table: "perPsicos");

            migrationBuilder.RenameTable(
                name: "pruebaPsicos",
                newName: "PruebaPsico");

            migrationBuilder.RenameTable(
                name: "perPsicos",
                newName: "PerPsico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PruebaPsico",
                table: "PruebaPsico",
                column: "IdPruebaPsico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerPsico",
                table: "PerPsico",
                column: "IdPerPsico");

            migrationBuilder.AddForeignKey(
                name: "FK_PerPsicoPruebaPsico_PerPsico_perPsicosIdPerPsico",
                table: "PerPsicoPruebaPsico",
                column: "perPsicosIdPerPsico",
                principalTable: "PerPsico",
                principalColumn: "IdPerPsico",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerPsicoPruebaPsico_PruebaPsico_PruebasPsicoIdPruebaPsico",
                table: "PerPsicoPruebaPsico",
                column: "PruebasPsicoIdPruebaPsico",
                principalTable: "PruebaPsico",
                principalColumn: "IdPruebaPsico",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerPsicoPruebaPsico_PerPsico_perPsicosIdPerPsico",
                table: "PerPsicoPruebaPsico");

            migrationBuilder.DropForeignKey(
                name: "FK_PerPsicoPruebaPsico_PruebaPsico_PruebasPsicoIdPruebaPsico",
                table: "PerPsicoPruebaPsico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PruebaPsico",
                table: "PruebaPsico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerPsico",
                table: "PerPsico");

            migrationBuilder.RenameTable(
                name: "PruebaPsico",
                newName: "pruebaPsicos");

            migrationBuilder.RenameTable(
                name: "PerPsico",
                newName: "perPsicos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pruebaPsicos",
                table: "pruebaPsicos",
                column: "IdPruebaPsico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_perPsicos",
                table: "perPsicos",
                column: "IdPerPsico");

            migrationBuilder.AddForeignKey(
                name: "FK_PerPsicoPruebaPsico_perPsicos_perPsicosIdPerPsico",
                table: "PerPsicoPruebaPsico",
                column: "perPsicosIdPerPsico",
                principalTable: "perPsicos",
                principalColumn: "IdPerPsico",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PerPsicoPruebaPsico_pruebaPsicos_PruebasPsicoIdPruebaPsico",
                table: "PerPsicoPruebaPsico",
                column: "PruebasPsicoIdPruebaPsico",
                principalTable: "pruebaPsicos",
                principalColumn: "IdPruebaPsico",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
