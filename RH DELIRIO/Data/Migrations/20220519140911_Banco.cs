using Microsoft.EntityFrameworkCore.Migrations;

namespace RH_DELIRIO.Data.Migrations
{
    public partial class Banco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HistoricosSalarios_FuncionarioId",
                table: "HistoricosSalarios");

            migrationBuilder.DropIndex(
                name: "IX_HistoricosFuncionarios_FuncionarioId",
                table: "HistoricosFuncionarios");

            migrationBuilder.DropIndex(
                name: "IX_HistoricosFerias_FuncionarioId",
                table: "HistoricosFerias");

            migrationBuilder.DropIndex(
                name: "IX_Familiares_FuncionarioId",
                table: "Familiares");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_FuncionarioId",
                table: "Eventos");

            migrationBuilder.DropIndex(
                name: "IX_Bancos_FuncionarioId",
                table: "Bancos");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosSalarios_FuncionarioId",
                table: "HistoricosSalarios",
                column: "FuncionarioId",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_FuncionarioId",
                table: "Eventos",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bancos_FuncionarioId",
                table: "Bancos",
                column: "FuncionarioId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HistoricosSalarios_FuncionarioId",
                table: "HistoricosSalarios");

            migrationBuilder.DropIndex(
                name: "IX_HistoricosFuncionarios_FuncionarioId",
                table: "HistoricosFuncionarios");

            migrationBuilder.DropIndex(
                name: "IX_HistoricosFerias_FuncionarioId",
                table: "HistoricosFerias");

            migrationBuilder.DropIndex(
                name: "IX_Familiares_FuncionarioId",
                table: "Familiares");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_FuncionarioId",
                table: "Eventos");

            migrationBuilder.DropIndex(
                name: "IX_Bancos_FuncionarioId",
                table: "Bancos");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosSalarios_FuncionarioId",
                table: "HistoricosSalarios",
                column: "FuncionarioId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_FuncionarioId",
                table: "Eventos",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Bancos_FuncionarioId",
                table: "Bancos",
                column: "FuncionarioId");
        }
    }
}
