﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class Funcionario : Entity
    {
        public Lojas loja_original { get; set; }

        public Lojas loja_anterior { get; set; }

        public Lojas loja_atual { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Required(ErrorMessage = "O nome do funcionário é obrigatório")]
        [Display(Name = "Nome do funcionário")]
        public string Nome { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Nome de Guerra")]
        public string nome_guerra { get; set; }

        public Divisao divisao { get; set; }

        public Cargos cargo_original { get; set; }

        public Cargos cargo_atual { get; set; }

        [Display(Name = "Registro do Contador")]
        public string registro_contador { get; set; }

        public Salarios salario { get; set; }

        public EnderecoFuncionario endereco { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        [Display(Name = "CPF")]
        public string cpf { get; set; }

        [Required(ErrorMessage = "O RG é obrigatório")]
        [Display(Name = "Registro Geral - RG")]
        public string rg { get; set; }

        public UnidadeDeFederacao uf_rg { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "A data de admissão é obrigatória")]
        [Display(Name = "Data de expedição")]
        public DateTime expedicao { get; set; }

        [Display(Name = "Orgão")]
        public string orgao { get; set; }

        [Display(Name = "Número da Carteira de Trabalho")]
        public string carteira_trabalho { get; set; }

        [Display(Name = "Série da Carteira de Trabalho")]
        public string serie_ct { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de emissão da Carteira de Trabalho")]
        public DateTime emissao_ct { get; set; }

        public UnidadeDeFederacao uf_ct { get; set; }

        public Bancos banco { get; set; }

        public Instrucao instrucao { get; set; }

        public Admissao admissao { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de afastamento")]
        public DateTime afastamento { get; set; }

        [Display(Name = "Causa de afastamento")]
        public string causa_afastamento { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de saída")]
        public DateTime saida { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Naturalidade")]
        public string naturalidade { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de nascimento")]
        public DateTime nascimento { get; set; }

        public UnidadeDeFederacao uf_nascimento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Cidade de nascimento")]
        public string cidade_nascimento { get; set; }

        public Familiares familiares { get; set; }

        [Display(Name = "PIS PASEP")]
        public string pis_pasep { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Banco PIS")]
        public string banco_pis { get; set; }

        [Display(Name = "Título de Eleitor")]
        public string titulo_eleitor { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Zona")]
        public string zona { get; set; }

        [Display(Name = "Seção")]
        public string secao { get; set; }

        public UnidadeDeFederacao uf_titulo { get; set; }

        public bool desconto_sindicato { get; set; }

        [Display(Name = "Tamanho da camisa")]
        public string tamanho_camisa { get; set; }

        [Display(Name = "Tamanho da calça")]
        public string tamanho_calca { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Observações")]
        public string observacoes { get; set; }

        //colocar upload de foto

        public TarifasDeOnibus vt { get; set; }

        public PlanoDeSaude plano_saude { get; set; }

        public TipoEstadoCivil TipoEstadoCivil { get; set; }

        public TipoGerencial TipoGerencial { get; set; }

        public TipoNacionalidade TipoNacionalidade { get; set; }

        public TipoSexo TipoSexo { get; set; }

        public TipoFuncionario TipoFuncionario { get; set; }

        public bool ativo { get; set; }

        public HorariosOriginais horarios_originais { get; set; }

        public HorariosAtuais horarios_atuais { get; set; }

        public HistoricoFerias historico_ferias { get; set; }

        public HistoricoFuncionario historico_funcionario { get; set; }

        public HistoricoSalario historico_salario { get; set; }

        public MotivosAfastamento motivos_afastamento { get; set; }

        //Relações do EF
        public IEnumerable <Bancos> Bancos { get; set; }

        public IEnumerable<EnderecoFuncionario> EnderecoFuncionario { get; set; }

        public IEnumerable<Familiares> Familiares { get; set; }

        public IEnumerable<HistoricoFerias> HistoricoFerias { get; set; }

        public IEnumerable<HistoricoFuncionario> HistoricoFuncionario { get; set; }

        public IEnumerable<HistoricoSalario> HistoricoSalario { get; set; }

       
    }
}
