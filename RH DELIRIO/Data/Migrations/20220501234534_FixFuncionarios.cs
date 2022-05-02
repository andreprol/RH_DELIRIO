using Microsoft.EntityFrameworkCore.Migrations;

namespace RH_DELIRIO.Data.Migrations
{
    public partial class FixFuncionarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EnderecosFuncionarios_FuncionarioId",
                table: "EnderecosFuncionarios");

            migrationBuilder.AddColumn<int>(
                name: "idfuncionario",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EnderecosFuncionarios_FuncionarioId",
                table: "EnderecosFuncionarios",
                column: "FuncionarioId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EnderecosFuncionarios_FuncionarioId",
                table: "EnderecosFuncionarios");

            migrationBuilder.DropColumn(
                name: "idfuncionario",
                table: "Funcionarios");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecosFuncionarios_FuncionarioId",
                table: "EnderecosFuncionarios",
                column: "FuncionarioId");
        }
    }
}
