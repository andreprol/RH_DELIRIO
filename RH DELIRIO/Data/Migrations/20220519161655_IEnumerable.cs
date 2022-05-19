using Microsoft.EntityFrameworkCore.Migrations;

namespace RH_DELIRIO.Data.Migrations
{
    public partial class IEnumerable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HistoricosFuncionarios_FuncionarioId",
                table: "HistoricosFuncionarios");

            migrationBuilder.DropIndex(
                name: "IX_HistoricosFerias_FuncionarioId",
                table: "HistoricosFerias");

            migrationBuilder.DropIndex(
                name: "IX_Familiares_FuncionarioId",
                table: "Familiares");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosFuncionarios_FuncionarioId",
                table: "HistoricosFuncionarios",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosFerias_FuncionarioId",
                table: "HistoricosFerias",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Familiares_FuncionarioId",
                table: "Familiares",
                column: "FuncionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HistoricosFuncionarios_FuncionarioId",
                table: "HistoricosFuncionarios");

            migrationBuilder.DropIndex(
                name: "IX_HistoricosFerias_FuncionarioId",
                table: "HistoricosFerias");

            migrationBuilder.DropIndex(
                name: "IX_Familiares_FuncionarioId",
                table: "Familiares");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosFuncionarios_FuncionarioId",
                table: "HistoricosFuncionarios",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosFerias_FuncionarioId",
                table: "HistoricosFerias",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Familiares_FuncionarioId",
                table: "Familiares",
                column: "FuncionarioId",
                unique: true);
        }
    }
}
