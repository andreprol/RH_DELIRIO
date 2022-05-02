using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RH_DELIRIO.Data.Migrations
{
    public partial class NewModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnderecoFuncionario_UnidadeDeFederacao_unidade_federacaoId",
                table: "EnderecoFuncionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Admissao_admissaoId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Bancos_bancoId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Cargos_cargo_atualId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Cargos_cargo_originalId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Divisao_divisaoId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_EnderecoFuncionario_enderecoId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_EstadoCivil_estado_civilId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Familiares_familiaresId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_HistoricoFerias_historico_feriasId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_HistoricoFuncionario_historico_funcionarioId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_HistoricoSalario_historico_salarioId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_HorariosAtuais_horarios_atuaisId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_HorariosOriginais_horarios_originaisId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Instrucao_instrucaoId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Lojas_loja_anteriorId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Lojas_loja_atualId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Lojas_loja_originalId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_MotivosAfastamento_motivos_afastamentoId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_PlanoDeSaude_plano_saudeId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Salarios_salarioId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_TarifasDeOnibus_vtId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_UnidadeDeFederacao_uf_ctId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_UnidadeDeFederacao_uf_nascimentoId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_UnidadeDeFederacao_uf_rgId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_UnidadeDeFederacao_uf_tituloId",
                table: "Funcionario");

            migrationBuilder.DropForeignKey(
                name: "FK_Lojas_EnderecoLojas_endereco_lojasId",
                table: "Lojas");

            migrationBuilder.DropTable(
                name: "EstadoCivil");

            migrationBuilder.DropIndex(
                name: "IX_Lojas_endereco_lojasId",
                table: "Lojas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanoDeSaude",
                table: "PlanoDeSaude");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotivosAfastamento",
                table: "MotivosAfastamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instrucao",
                table: "Instrucao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoricoSalario",
                table: "HistoricoSalario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoricoFuncionario",
                table: "HistoricoFuncionario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoricoFerias",
                table: "HistoricoFerias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionario",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_admissaoId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_bancoId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_cargo_atualId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_cargo_originalId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_divisaoId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_enderecoId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_estado_civilId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_familiaresId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_historico_feriasId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_historico_funcionarioId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_historico_salarioId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_horarios_atuaisId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_horarios_originaisId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_instrucaoId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_loja_anteriorId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_loja_atualId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_loja_originalId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_motivos_afastamentoId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_plano_saudeId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_salarioId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_uf_ctId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_uf_nascimentoId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_uf_rgId",
                table: "Funcionario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnderecoLojas",
                table: "EnderecoLojas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnderecoFuncionario",
                table: "EnderecoFuncionario");

            migrationBuilder.DropIndex(
                name: "IX_EnderecoFuncionario_unidade_federacaoId",
                table: "EnderecoFuncionario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Divisao",
                table: "Divisao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admissao",
                table: "Admissao");

            migrationBuilder.DropColumn(
                name: "descricao",
                table: "Lojas");

            migrationBuilder.DropColumn(
                name: "endereco_lojasId",
                table: "Lojas");

            migrationBuilder.DropColumn(
                name: "admissaoId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "bancoId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "cargo_atualId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "cargo_originalId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "divisaoId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "enderecoId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "estado_civilId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "familiaresId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "historico_feriasId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "historico_funcionarioId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "historico_salarioId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "horarios_atuaisId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "horarios_originaisId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "instrucaoId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "loja_anteriorId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "loja_atualId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "loja_originalId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "motivos_afastamentoId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "plano_saudeId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "salarioId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "uf_ctId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "uf_nascimentoId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "uf_rgId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "unidade_federacaoId",
                table: "EnderecoFuncionario");

            migrationBuilder.RenameTable(
                name: "PlanoDeSaude",
                newName: "PlanosDeSaude");

            migrationBuilder.RenameTable(
                name: "MotivosAfastamento",
                newName: "MotivosAfastamentos");

            migrationBuilder.RenameTable(
                name: "Instrucao",
                newName: "Instrucoes");

            migrationBuilder.RenameTable(
                name: "HistoricoSalario",
                newName: "HistoricosSalarios");

            migrationBuilder.RenameTable(
                name: "HistoricoFuncionario",
                newName: "HistoricosFuncionarios");

            migrationBuilder.RenameTable(
                name: "HistoricoFerias",
                newName: "HistoricosFerias");

            migrationBuilder.RenameTable(
                name: "Funcionario",
                newName: "Funcionarios");

            migrationBuilder.RenameTable(
                name: "EnderecoLojas",
                newName: "EnderecosLojas");

            migrationBuilder.RenameTable(
                name: "EnderecoFuncionario",
                newName: "EnderecosFuncionarios");

            migrationBuilder.RenameTable(
                name: "Divisao",
                newName: "Divisoes");

            migrationBuilder.RenameTable(
                name: "Admissao",
                newName: "Admissoes");

            migrationBuilder.RenameColumn(
                name: "vtId",
                table: "Funcionarios",
                newName: "UnidadeDeFederacaoId");

            migrationBuilder.RenameColumn(
                name: "uf_tituloId",
                table: "Funcionarios",
                newName: "CargosId1");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionario_vtId",
                table: "Funcionarios",
                newName: "IX_Funcionarios_UnidadeDeFederacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionario_uf_tituloId",
                table: "Funcionarios",
                newName: "IX_Funcionarios_CargosId1");

            migrationBuilder.AlterColumn<string>(
                name: "sigla",
                table: "UnidadeDeFederacao",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "estado",
                table: "UnidadeDeFederacao",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "tipo",
                table: "TarifasDeOnibus",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "TarifasDeOnibus",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "cargo_original",
                table: "Salarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cargo_atual",
                table: "Salarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "Salarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "sigla",
                table: "Lojas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "razao_social",
                table: "Lojas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "inscricao_estadual",
                table: "Lojas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cod_amil",
                table: "Lojas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cnpj",
                table: "Lojas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descricaoAnterior",
                table: "Lojas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descricaoAtual",
                table: "Lojas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descricaoOriginal",
                table: "Lojas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "HorariosOriginais",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "HorariosAtuais",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "nome_pai",
                table: "Familiares",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome_mae",
                table: "Familiares",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome_filho",
                table: "Familiares",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "Familiares",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "descricao_evento",
                table: "Eventos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "Eventos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Cargos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "abreviacao",
                table: "Cargos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "Cargos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "numero_banco",
                table: "Bancos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descricao_banco",
                table: "Bancos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "conta_banco",
                table: "Bancos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "agencia_banco",
                table: "Bancos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "Bancos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "plano",
                table: "PlanosDeSaude",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "PlanosDeSaude",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "MotivosAfastamentos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "MotivosAfastamentos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Instrucoes",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "Instrucoes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "HistoricosSalarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "HistoricosFuncionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "HistoricosFuncionarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "HistoricosFerias",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "zona",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "titulo_eleitor",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "tamanho_camisa",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "tamanho_calca",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "serie_ct",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "secao",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "rg",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "registro_contador",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "pis_pasep",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "orgao",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "observacoes",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome_guerra",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "naturalidade",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "cidade_nascimento",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "causa_afastamento",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "carteira_trabalho",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "banco_pis",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Funcionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "CargosId",
                table: "Funcionarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LojasId",
                table: "Funcionarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "TipoEstadoCivil",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoFuncionario",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoGerencial",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoNacionalidade",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoSexo",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ativo",
                table: "Funcionarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "foto",
                table: "Funcionarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "rua",
                table: "EnderecosLojas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "EnderecosLojas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "complemento",
                table: "EnderecosLojas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "EnderecosLojas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "bairro",
                table: "EnderecosLojas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LojasId",
                table: "EnderecosLojas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UnidadeDeFederacaoId",
                table: "EnderecosLojas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "cep",
                table: "EnderecosLojas",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "rua",
                table: "EnderecosFuncionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "EnderecosFuncionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "complemento",
                table: "EnderecosFuncionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "EnderecosFuncionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "bairro",
                table: "EnderecosFuncionarios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "EnderecosFuncionarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UnidadeDeFederacaoId",
                table: "EnderecosFuncionarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "cep",
                table: "EnderecosFuncionarios",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Divisoes",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "Divisoes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "tipo",
                table: "Admissoes",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "Admissoes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanosDeSaude",
                table: "PlanosDeSaude",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotivosAfastamentos",
                table: "MotivosAfastamentos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instrucoes",
                table: "Instrucoes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoricosSalarios",
                table: "HistoricosSalarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoricosFuncionarios",
                table: "HistoricosFuncionarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoricosFerias",
                table: "HistoricosFerias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnderecosLojas",
                table: "EnderecosLojas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnderecosFuncionarios",
                table: "EnderecosFuncionarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Divisoes",
                table: "Divisoes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admissoes",
                table: "Admissoes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TarifasDeOnibus_FuncionarioId",
                table: "TarifasDeOnibus",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Salarios_FuncionarioId",
                table: "Salarios",
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
                name: "IX_Funcionarios_LojasId",
                table: "Funcionarios",
                column: "LojasId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecosLojas_LojasId",
                table: "EnderecosLojas",
                column: "LojasId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecosLojas_UnidadeDeFederacaoId",
                table: "EnderecosLojas",
                column: "UnidadeDeFederacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecosFuncionarios_FuncionarioId",
                table: "EnderecosFuncionarios",
                column: "FuncionarioId");

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
                name: "FK_Admissoes_Funcionarios_FuncionarioId",
                table: "Admissoes",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bancos_Funcionarios_FuncionarioId",
                table: "Bancos",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Divisoes_Funcionarios_FuncionarioId",
                table: "Divisoes",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecosFuncionarios_Funcionarios_FuncionarioId",
                table: "EnderecosFuncionarios",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecosFuncionarios_UnidadeDeFederacao_UnidadeDeFederacaoId",
                table: "EnderecosFuncionarios",
                column: "UnidadeDeFederacaoId",
                principalTable: "UnidadeDeFederacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecosLojas_Lojas_LojasId",
                table: "EnderecosLojas",
                column: "LojasId",
                principalTable: "Lojas",
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
                name: "FK_Eventos_Funcionarios_FuncionarioId",
                table: "Eventos",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Familiares_Funcionarios_FuncionarioId",
                table: "Familiares",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
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

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricosFerias_Funcionarios_FuncionarioId",
                table: "HistoricosFerias",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricosFuncionarios_Funcionarios_FuncionarioId",
                table: "HistoricosFuncionarios",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricosSalarios_Funcionarios_FuncionarioId",
                table: "HistoricosSalarios",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HorariosAtuais_Funcionarios_FuncionarioId",
                table: "HorariosAtuais",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HorariosOriginais_Funcionarios_FuncionarioId",
                table: "HorariosOriginais",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instrucoes_Funcionarios_FuncionarioId",
                table: "Instrucoes",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MotivosAfastamentos_Funcionarios_FuncionarioId",
                table: "MotivosAfastamentos",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanosDeSaude_Funcionarios_FuncionarioId",
                table: "PlanosDeSaude",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salarios_Funcionarios_FuncionarioId",
                table: "Salarios",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TarifasDeOnibus_Funcionarios_FuncionarioId",
                table: "TarifasDeOnibus",
                column: "FuncionarioId",
                principalTable: "Funcionarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admissoes_Funcionarios_FuncionarioId",
                table: "Admissoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Bancos_Funcionarios_FuncionarioId",
                table: "Bancos");

            migrationBuilder.DropForeignKey(
                name: "FK_Divisoes_Funcionarios_FuncionarioId",
                table: "Divisoes");

            migrationBuilder.DropForeignKey(
                name: "FK_EnderecosFuncionarios_Funcionarios_FuncionarioId",
                table: "EnderecosFuncionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_EnderecosFuncionarios_UnidadeDeFederacao_UnidadeDeFederacaoId",
                table: "EnderecosFuncionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_EnderecosLojas_Lojas_LojasId",
                table: "EnderecosLojas");

            migrationBuilder.DropForeignKey(
                name: "FK_EnderecosLojas_UnidadeDeFederacao_UnidadeDeFederacaoId",
                table: "EnderecosLojas");

            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Funcionarios_FuncionarioId",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_Familiares_Funcionarios_FuncionarioId",
                table: "Familiares");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Cargos_CargosId1",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Lojas_LojasId",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_UnidadeDeFederacao_UnidadeDeFederacaoId",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricosFerias_Funcionarios_FuncionarioId",
                table: "HistoricosFerias");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricosFuncionarios_Funcionarios_FuncionarioId",
                table: "HistoricosFuncionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricosSalarios_Funcionarios_FuncionarioId",
                table: "HistoricosSalarios");

            migrationBuilder.DropForeignKey(
                name: "FK_HorariosAtuais_Funcionarios_FuncionarioId",
                table: "HorariosAtuais");

            migrationBuilder.DropForeignKey(
                name: "FK_HorariosOriginais_Funcionarios_FuncionarioId",
                table: "HorariosOriginais");

            migrationBuilder.DropForeignKey(
                name: "FK_Instrucoes_Funcionarios_FuncionarioId",
                table: "Instrucoes");

            migrationBuilder.DropForeignKey(
                name: "FK_MotivosAfastamentos_Funcionarios_FuncionarioId",
                table: "MotivosAfastamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanosDeSaude_Funcionarios_FuncionarioId",
                table: "PlanosDeSaude");

            migrationBuilder.DropForeignKey(
                name: "FK_Salarios_Funcionarios_FuncionarioId",
                table: "Salarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TarifasDeOnibus_Funcionarios_FuncionarioId",
                table: "TarifasDeOnibus");

            migrationBuilder.DropIndex(
                name: "IX_TarifasDeOnibus_FuncionarioId",
                table: "TarifasDeOnibus");

            migrationBuilder.DropIndex(
                name: "IX_Salarios_FuncionarioId",
                table: "Salarios");

            migrationBuilder.DropIndex(
                name: "IX_HorariosOriginais_FuncionarioId",
                table: "HorariosOriginais");

            migrationBuilder.DropIndex(
                name: "IX_HorariosAtuais_FuncionarioId",
                table: "HorariosAtuais");

            migrationBuilder.DropIndex(
                name: "IX_Familiares_FuncionarioId",
                table: "Familiares");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_FuncionarioId",
                table: "Eventos");

            migrationBuilder.DropIndex(
                name: "IX_Bancos_FuncionarioId",
                table: "Bancos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanosDeSaude",
                table: "PlanosDeSaude");

            migrationBuilder.DropIndex(
                name: "IX_PlanosDeSaude_FuncionarioId",
                table: "PlanosDeSaude");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotivosAfastamentos",
                table: "MotivosAfastamentos");

            migrationBuilder.DropIndex(
                name: "IX_MotivosAfastamentos_FuncionarioId",
                table: "MotivosAfastamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instrucoes",
                table: "Instrucoes");

            migrationBuilder.DropIndex(
                name: "IX_Instrucoes_FuncionarioId",
                table: "Instrucoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoricosSalarios",
                table: "HistoricosSalarios");

            migrationBuilder.DropIndex(
                name: "IX_HistoricosSalarios_FuncionarioId",
                table: "HistoricosSalarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoricosFuncionarios",
                table: "HistoricosFuncionarios");

            migrationBuilder.DropIndex(
                name: "IX_HistoricosFuncionarios_FuncionarioId",
                table: "HistoricosFuncionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoricosFerias",
                table: "HistoricosFerias");

            migrationBuilder.DropIndex(
                name: "IX_HistoricosFerias_FuncionarioId",
                table: "HistoricosFerias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_LojasId",
                table: "Funcionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnderecosLojas",
                table: "EnderecosLojas");

            migrationBuilder.DropIndex(
                name: "IX_EnderecosLojas_LojasId",
                table: "EnderecosLojas");

            migrationBuilder.DropIndex(
                name: "IX_EnderecosLojas_UnidadeDeFederacaoId",
                table: "EnderecosLojas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EnderecosFuncionarios",
                table: "EnderecosFuncionarios");

            migrationBuilder.DropIndex(
                name: "IX_EnderecosFuncionarios_FuncionarioId",
                table: "EnderecosFuncionarios");

            migrationBuilder.DropIndex(
                name: "IX_EnderecosFuncionarios_UnidadeDeFederacaoId",
                table: "EnderecosFuncionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Divisoes",
                table: "Divisoes");

            migrationBuilder.DropIndex(
                name: "IX_Divisoes_FuncionarioId",
                table: "Divisoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admissoes",
                table: "Admissoes");

            migrationBuilder.DropIndex(
                name: "IX_Admissoes_FuncionarioId",
                table: "Admissoes");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "TarifasDeOnibus");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Salarios");

            migrationBuilder.DropColumn(
                name: "descricaoAnterior",
                table: "Lojas");

            migrationBuilder.DropColumn(
                name: "descricaoAtual",
                table: "Lojas");

            migrationBuilder.DropColumn(
                name: "descricaoOriginal",
                table: "Lojas");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "HorariosOriginais");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "HorariosAtuais");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Familiares");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Bancos");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "PlanosDeSaude");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "MotivosAfastamentos");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Instrucoes");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "HistoricosSalarios");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "HistoricosFuncionarios");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "HistoricosFerias");

            migrationBuilder.DropColumn(
                name: "CargosId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "LojasId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "TipoEstadoCivil",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "TipoFuncionario",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "TipoGerencial",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "TipoNacionalidade",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "TipoSexo",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "ativo",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "foto",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "LojasId",
                table: "EnderecosLojas");

            migrationBuilder.DropColumn(
                name: "UnidadeDeFederacaoId",
                table: "EnderecosLojas");

            migrationBuilder.DropColumn(
                name: "cep",
                table: "EnderecosLojas");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "EnderecosFuncionarios");

            migrationBuilder.DropColumn(
                name: "UnidadeDeFederacaoId",
                table: "EnderecosFuncionarios");

            migrationBuilder.DropColumn(
                name: "cep",
                table: "EnderecosFuncionarios");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Divisoes");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Admissoes");

            migrationBuilder.RenameTable(
                name: "PlanosDeSaude",
                newName: "PlanoDeSaude");

            migrationBuilder.RenameTable(
                name: "MotivosAfastamentos",
                newName: "MotivosAfastamento");

            migrationBuilder.RenameTable(
                name: "Instrucoes",
                newName: "Instrucao");

            migrationBuilder.RenameTable(
                name: "HistoricosSalarios",
                newName: "HistoricoSalario");

            migrationBuilder.RenameTable(
                name: "HistoricosFuncionarios",
                newName: "HistoricoFuncionario");

            migrationBuilder.RenameTable(
                name: "HistoricosFerias",
                newName: "HistoricoFerias");

            migrationBuilder.RenameTable(
                name: "Funcionarios",
                newName: "Funcionario");

            migrationBuilder.RenameTable(
                name: "EnderecosLojas",
                newName: "EnderecoLojas");

            migrationBuilder.RenameTable(
                name: "EnderecosFuncionarios",
                newName: "EnderecoFuncionario");

            migrationBuilder.RenameTable(
                name: "Divisoes",
                newName: "Divisao");

            migrationBuilder.RenameTable(
                name: "Admissoes",
                newName: "Admissao");

            migrationBuilder.RenameColumn(
                name: "UnidadeDeFederacaoId",
                table: "Funcionario",
                newName: "vtId");

            migrationBuilder.RenameColumn(
                name: "CargosId1",
                table: "Funcionario",
                newName: "uf_tituloId");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionarios_UnidadeDeFederacaoId",
                table: "Funcionario",
                newName: "IX_Funcionario_vtId");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionarios_CargosId1",
                table: "Funcionario",
                newName: "IX_Funcionario_uf_tituloId");

            migrationBuilder.AlterColumn<string>(
                name: "sigla",
                table: "UnidadeDeFederacao",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "estado",
                table: "UnidadeDeFederacao",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "tipo",
                table: "TarifasDeOnibus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cargo_original",
                table: "Salarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cargo_atual",
                table: "Salarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "sigla",
                table: "Lojas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "razao_social",
                table: "Lojas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "inscricao_estadual",
                table: "Lojas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cod_amil",
                table: "Lojas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cnpj",
                table: "Lojas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descricao",
                table: "Lojas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "endereco_lojasId",
                table: "Lojas",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome_pai",
                table: "Familiares",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome_mae",
                table: "Familiares",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome_filho",
                table: "Familiares",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descricao_evento",
                table: "Eventos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Cargos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "abreviacao",
                table: "Cargos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "numero_banco",
                table: "Bancos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descricao_banco",
                table: "Bancos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "conta_banco",
                table: "Bancos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "agencia_banco",
                table: "Bancos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "plano",
                table: "PlanoDeSaude",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "MotivosAfastamento",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Instrucao",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "HistoricoFuncionario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "zona",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "titulo_eleitor",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "tamanho_camisa",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "tamanho_calca",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "serie_ct",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "secao",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "rg",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "registro_contador",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "pis_pasep",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "orgao",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "observacoes",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome_guerra",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "naturalidade",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "cidade_nascimento",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "causa_afastamento",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "carteira_trabalho",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "banco_pis",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<Guid>(
                name: "admissaoId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "bancoId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "cargo_atualId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "cargo_originalId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "divisaoId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "enderecoId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "estado_civilId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "familiaresId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "historico_feriasId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "historico_funcionarioId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "historico_salarioId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "horarios_atuaisId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "horarios_originaisId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "instrucaoId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "loja_anteriorId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "loja_atualId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "loja_originalId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "motivos_afastamentoId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "plano_saudeId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "salarioId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "uf_ctId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "uf_nascimentoId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "uf_rgId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "rua",
                table: "EnderecoLojas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "numero",
                table: "EnderecoLojas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "complemento",
                table: "EnderecoLojas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "EnderecoLojas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "bairro",
                table: "EnderecoLojas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "rua",
                table: "EnderecoFuncionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "numero",
                table: "EnderecoFuncionario",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "complemento",
                table: "EnderecoFuncionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "EnderecoFuncionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "bairro",
                table: "EnderecoFuncionario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<Guid>(
                name: "unidade_federacaoId",
                table: "EnderecoFuncionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Divisao",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "tipo",
                table: "Admissao",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanoDeSaude",
                table: "PlanoDeSaude",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotivosAfastamento",
                table: "MotivosAfastamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instrucao",
                table: "Instrucao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoricoSalario",
                table: "HistoricoSalario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoricoFuncionario",
                table: "HistoricoFuncionario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoricoFerias",
                table: "HistoricoFerias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionario",
                table: "Funcionario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnderecoLojas",
                table: "EnderecoLojas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EnderecoFuncionario",
                table: "EnderecoFuncionario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Divisao",
                table: "Divisao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admissao",
                table: "Admissao",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EstadoCivil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCivil", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lojas_endereco_lojasId",
                table: "Lojas",
                column: "endereco_lojasId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_admissaoId",
                table: "Funcionario",
                column: "admissaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_bancoId",
                table: "Funcionario",
                column: "bancoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_cargo_atualId",
                table: "Funcionario",
                column: "cargo_atualId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_cargo_originalId",
                table: "Funcionario",
                column: "cargo_originalId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_divisaoId",
                table: "Funcionario",
                column: "divisaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_enderecoId",
                table: "Funcionario",
                column: "enderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_estado_civilId",
                table: "Funcionario",
                column: "estado_civilId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_familiaresId",
                table: "Funcionario",
                column: "familiaresId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_historico_feriasId",
                table: "Funcionario",
                column: "historico_feriasId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_historico_funcionarioId",
                table: "Funcionario",
                column: "historico_funcionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_historico_salarioId",
                table: "Funcionario",
                column: "historico_salarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_horarios_atuaisId",
                table: "Funcionario",
                column: "horarios_atuaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_horarios_originaisId",
                table: "Funcionario",
                column: "horarios_originaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_instrucaoId",
                table: "Funcionario",
                column: "instrucaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_loja_anteriorId",
                table: "Funcionario",
                column: "loja_anteriorId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_loja_atualId",
                table: "Funcionario",
                column: "loja_atualId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_loja_originalId",
                table: "Funcionario",
                column: "loja_originalId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_motivos_afastamentoId",
                table: "Funcionario",
                column: "motivos_afastamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_plano_saudeId",
                table: "Funcionario",
                column: "plano_saudeId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_salarioId",
                table: "Funcionario",
                column: "salarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_uf_ctId",
                table: "Funcionario",
                column: "uf_ctId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_uf_nascimentoId",
                table: "Funcionario",
                column: "uf_nascimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_uf_rgId",
                table: "Funcionario",
                column: "uf_rgId");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoFuncionario_unidade_federacaoId",
                table: "EnderecoFuncionario",
                column: "unidade_federacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecoFuncionario_UnidadeDeFederacao_unidade_federacaoId",
                table: "EnderecoFuncionario",
                column: "unidade_federacaoId",
                principalTable: "UnidadeDeFederacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Admissao_admissaoId",
                table: "Funcionario",
                column: "admissaoId",
                principalTable: "Admissao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Bancos_bancoId",
                table: "Funcionario",
                column: "bancoId",
                principalTable: "Bancos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Cargos_cargo_atualId",
                table: "Funcionario",
                column: "cargo_atualId",
                principalTable: "Cargos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Cargos_cargo_originalId",
                table: "Funcionario",
                column: "cargo_originalId",
                principalTable: "Cargos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Divisao_divisaoId",
                table: "Funcionario",
                column: "divisaoId",
                principalTable: "Divisao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_EnderecoFuncionario_enderecoId",
                table: "Funcionario",
                column: "enderecoId",
                principalTable: "EnderecoFuncionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_EstadoCivil_estado_civilId",
                table: "Funcionario",
                column: "estado_civilId",
                principalTable: "EstadoCivil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Familiares_familiaresId",
                table: "Funcionario",
                column: "familiaresId",
                principalTable: "Familiares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_HistoricoFerias_historico_feriasId",
                table: "Funcionario",
                column: "historico_feriasId",
                principalTable: "HistoricoFerias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_HistoricoFuncionario_historico_funcionarioId",
                table: "Funcionario",
                column: "historico_funcionarioId",
                principalTable: "HistoricoFuncionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_HistoricoSalario_historico_salarioId",
                table: "Funcionario",
                column: "historico_salarioId",
                principalTable: "HistoricoSalario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_HorariosAtuais_horarios_atuaisId",
                table: "Funcionario",
                column: "horarios_atuaisId",
                principalTable: "HorariosAtuais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_HorariosOriginais_horarios_originaisId",
                table: "Funcionario",
                column: "horarios_originaisId",
                principalTable: "HorariosOriginais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Instrucao_instrucaoId",
                table: "Funcionario",
                column: "instrucaoId",
                principalTable: "Instrucao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Lojas_loja_anteriorId",
                table: "Funcionario",
                column: "loja_anteriorId",
                principalTable: "Lojas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Lojas_loja_atualId",
                table: "Funcionario",
                column: "loja_atualId",
                principalTable: "Lojas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Lojas_loja_originalId",
                table: "Funcionario",
                column: "loja_originalId",
                principalTable: "Lojas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_MotivosAfastamento_motivos_afastamentoId",
                table: "Funcionario",
                column: "motivos_afastamentoId",
                principalTable: "MotivosAfastamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_PlanoDeSaude_plano_saudeId",
                table: "Funcionario",
                column: "plano_saudeId",
                principalTable: "PlanoDeSaude",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Salarios_salarioId",
                table: "Funcionario",
                column: "salarioId",
                principalTable: "Salarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_TarifasDeOnibus_vtId",
                table: "Funcionario",
                column: "vtId",
                principalTable: "TarifasDeOnibus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_UnidadeDeFederacao_uf_ctId",
                table: "Funcionario",
                column: "uf_ctId",
                principalTable: "UnidadeDeFederacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_UnidadeDeFederacao_uf_nascimentoId",
                table: "Funcionario",
                column: "uf_nascimentoId",
                principalTable: "UnidadeDeFederacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_UnidadeDeFederacao_uf_rgId",
                table: "Funcionario",
                column: "uf_rgId",
                principalTable: "UnidadeDeFederacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_UnidadeDeFederacao_uf_tituloId",
                table: "Funcionario",
                column: "uf_tituloId",
                principalTable: "UnidadeDeFederacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lojas_EnderecoLojas_endereco_lojasId",
                table: "Lojas",
                column: "endereco_lojasId",
                principalTable: "EnderecoLojas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
