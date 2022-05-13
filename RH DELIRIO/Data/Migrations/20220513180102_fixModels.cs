using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RH_DELIRIO.Data.Migrations
{
    public partial class fixModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnderecosFuncionarios_UnidadeDeFederacao_UnidadeDeFederacaoId",
                table: "EnderecosFuncionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_EnderecosLojas_UnidadeDeFederacao_UnidadeDeFederacaoId",
                table: "EnderecosLojas");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Cargos_CargosId1",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Lojas_LojasId",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_UnidadeDeFederacao_UnidadeDeFederacaoId",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_TarifasDeOnibus_FuncionarioId",
                table: "TarifasDeOnibus");

            migrationBuilder.DropIndex(
                name: "IX_Salarios_FuncionarioId",
                table: "Salarios");

            migrationBuilder.DropIndex(
                name: "IX_PlanosDeSaude_FuncionarioId",
                table: "PlanosDeSaude");

            migrationBuilder.DropIndex(
                name: "IX_MotivosAfastamentos_FuncionarioId",
                table: "MotivosAfastamentos");

            migrationBuilder.DropIndex(
                name: "IX_Instrucoes_FuncionarioId",
                table: "Instrucoes");

            migrationBuilder.DropIndex(
                name: "IX_HorariosOriginais_FuncionarioId",
                table: "HorariosOriginais");

            migrationBuilder.DropIndex(
                name: "IX_HorariosAtuais_FuncionarioId",
                table: "HorariosAtuais");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_CargosId1",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_LojasId",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_UnidadeDeFederacaoId",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_EnderecosLojas_UnidadeDeFederacaoId",
                table: "EnderecosLojas");

            migrationBuilder.DropIndex(
                name: "IX_EnderecosFuncionarios_UnidadeDeFederacaoId",
                table: "EnderecosFuncionarios");

            migrationBuilder.DropIndex(
                name: "IX_Divisoes_FuncionarioId",
                table: "Divisoes");

            migrationBuilder.DropIndex(
                name: "IX_Admissoes_FuncionarioId",
                table: "Admissoes");

            migrationBuilder.DropColumn(
                name: "CargosId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "CargosId1",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "LojasId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "UnidadeDeFederacaoId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "UnidadeDeFederacaoId",
                table: "EnderecosLojas");

            migrationBuilder.DropColumn(
                name: "UnidadeDeFederacaoId",
                table: "EnderecosFuncionarios");

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "UnidadeDeFederacao",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "Lojas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_UnidadeDeFederacao_FuncionarioId",
                table: "UnidadeDeFederacao",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TarifasDeOnibus_FuncionarioId",
                table: "TarifasDeOnibus",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salarios_FuncionarioId",
                table: "Salarios",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlanosDeSaude_FuncionarioId",
                table: "PlanosDeSaude",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MotivosAfastamentos_FuncionarioId",
                table: "MotivosAfastamentos",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lojas_FuncionarioId",
                table: "Lojas",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instrucoes_FuncionarioId",
                table: "Instrucoes",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HorariosOriginais_FuncionarioId",
                table: "HorariosOriginais",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HorariosAtuais_FuncionarioId",
                table: "HorariosAtuais",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Divisoes_FuncionarioId",
                table: "Divisoes",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_FuncionarioId",
                table: "Cargos",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Admissoes_FuncionarioId",
                table: "Admissoes",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cargos_Funcionarios_FuncionarioId",
                table: "Cargos",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lojas_Funcionarios_FuncionarioId",
                table: "Lojas",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnidadeDeFederacao_Funcionarios_FuncionarioId",
                table: "UnidadeDeFederacao",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargos_Funcionarios_FuncionarioId",
                table: "Cargos");

            migrationBuilder.DropForeignKey(
                name: "FK_Lojas_Funcionarios_FuncionarioId",
                table: "Lojas");

            migrationBuilder.DropForeignKey(
                name: "FK_UnidadeDeFederacao_Funcionarios_FuncionarioId",
                table: "UnidadeDeFederacao");

            migrationBuilder.DropIndex(
                name: "IX_UnidadeDeFederacao_FuncionarioId",
                table: "UnidadeDeFederacao");

            migrationBuilder.DropIndex(
                name: "IX_TarifasDeOnibus_FuncionarioId",
                table: "TarifasDeOnibus");

            migrationBuilder.DropIndex(
                name: "IX_Salarios_FuncionarioId",
                table: "Salarios");

            migrationBuilder.DropIndex(
                name: "IX_PlanosDeSaude_FuncionarioId",
                table: "PlanosDeSaude");

            migrationBuilder.DropIndex(
                name: "IX_MotivosAfastamentos_FuncionarioId",
                table: "MotivosAfastamentos");

            migrationBuilder.DropIndex(
                name: "IX_Lojas_FuncionarioId",
                table: "Lojas");

            migrationBuilder.DropIndex(
                name: "IX_Instrucoes_FuncionarioId",
                table: "Instrucoes");

            migrationBuilder.DropIndex(
                name: "IX_HorariosOriginais_FuncionarioId",
                table: "HorariosOriginais");

            migrationBuilder.DropIndex(
                name: "IX_HorariosAtuais_FuncionarioId",
                table: "HorariosAtuais");

            migrationBuilder.DropIndex(
                name: "IX_Divisoes_FuncionarioId",
                table: "Divisoes");

            migrationBuilder.DropIndex(
                name: "IX_Cargos_FuncionarioId",
                table: "Cargos");

            migrationBuilder.DropIndex(
                name: "IX_Admissoes_FuncionarioId",
                table: "Admissoes");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "UnidadeDeFederacao");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Lojas");

            migrationBuilder.AddColumn<Guid>(
                name: "CargosId",
                table: "Funcionarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CargosId1",
                table: "Funcionarios",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LojasId",
                table: "Funcionarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UnidadeDeFederacaoId",
                table: "Funcionarios",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UnidadeDeFederacaoId",
                table: "EnderecosLojas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UnidadeDeFederacaoId",
                table: "EnderecosFuncionarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_TarifasDeOnibus_FuncionarioId",
                table: "TarifasDeOnibus",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Salarios_FuncionarioId",
                table: "Salarios",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanosDeSaude_FuncionarioId",
                table: "PlanosDeSaude",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_MotivosAfastamentos_FuncionarioId",
                table: "MotivosAfastamentos",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Instrucoes_FuncionarioId",
                table: "Instrucoes",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HorariosOriginais_FuncionarioId",
                table: "HorariosOriginais",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_HorariosAtuais_FuncionarioId",
                table: "HorariosAtuais",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_CargosId1",
                table: "Funcionarios",
                column: "CargosId1");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_LojasId",
                table: "Funcionarios",
                column: "LojasId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_UnidadeDeFederacaoId",
                table: "Funcionarios",
                column: "UnidadeDeFederacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecosLojas_UnidadeDeFederacaoId",
                table: "EnderecosLojas",
                column: "UnidadeDeFederacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecosFuncionarios_UnidadeDeFederacaoId",
                table: "EnderecosFuncionarios",
                column: "UnidadeDeFederacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Divisoes_FuncionarioId",
                table: "Divisoes",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Admissoes_FuncionarioId",
                table: "Admissoes",
                column: "FuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecosFuncionarios_UnidadeDeFederacao_UnidadeDeFederacaoId",
                table: "EnderecosFuncionarios",
                column: "UnidadeDeFederacaoId",
                principalTable: "UnidadeDeFederacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecosLojas_UnidadeDeFederacao_UnidadeDeFederacaoId",
                table: "EnderecosLojas",
                column: "UnidadeDeFederacaoId",
                principalTable: "UnidadeDeFederacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Cargos_CargosId1",
                table: "Funcionarios",
                column: "CargosId1",
                principalTable: "Cargos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Lojas_LojasId",
                table: "Funcionarios",
                column: "LojasId",
                principalTable: "Lojas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_UnidadeDeFederacao_UnidadeDeFederacaoId",
                table: "Funcionarios",
                column: "UnidadeDeFederacaoId",
                principalTable: "UnidadeDeFederacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
