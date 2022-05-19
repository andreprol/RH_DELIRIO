using Microsoft.EntityFrameworkCore.Migrations;

namespace RH_DELIRIO.Data.Migrations
{
    public partial class Evento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Eventos_FuncionarioId",
                table: "Eventos");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_FuncionarioId",
                table: "Eventos",
                column: "FuncionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Eventos_FuncionarioId",
                table: "Eventos");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_FuncionarioId",
                table: "Eventos",
                column: "FuncionarioId",
                unique: true);
        }
    }
}
