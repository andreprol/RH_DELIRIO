using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class Funcionario : Entity
    {

        public Guid LojasId { get; set; }

        public Guid CargosId { get; set; }

        [Required(ErrorMessage = "O ID do funcionário é obrigatório")]
        [Display(Name = "ID do funcionário")]
        public int idfuncionario { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Required(ErrorMessage = "O nome do funcionário é obrigatório")]
        [Display(Name = "Nome do funcionário")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Nome de Guerra")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string nome_guerra { get; set; }


        [Display(Name = "Registro do Contador")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string registro_contador { get; set; }


        [Required(ErrorMessage = "O CPF é obrigatório")]
        [Display(Name = "CPF")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string cpf { get; set; }

        [Required(ErrorMessage = "O RG é obrigatório")]
        [Display(Name = "Registro Geral - RG")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string rg { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "A data de admissão é obrigatória")]
        [Display(Name = "Data de expedição")]
        public DateTime expedicao { get; set; }

        [Display(Name = "Orgão")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string orgao { get; set; }

        [Display(Name = "Número da Carteira de Trabalho")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string carteira_trabalho { get; set; }

        [Display(Name = "Série da Carteira de Trabalho")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string serie_ct { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de emissão da Carteira de Trabalho")]
        public DateTime emissao_ct { get; set; }

        
        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de afastamento")]
        public DateTime afastamento { get; set; }

        [Display(Name = "Causa de afastamento")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string causa_afastamento { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de saída")]
        public DateTime saida { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Naturalidade")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string naturalidade { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de nascimento")]
        public DateTime nascimento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Cidade de nascimento")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string cidade_nascimento { get; set; }

        [Display(Name = "PIS PASEP")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string pis_pasep { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Banco PIS")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string banco_pis { get; set; }

        [Display(Name = "Título de Eleitor")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string titulo_eleitor { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Zona")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string zona { get; set; }

        [Display(Name = "Seção")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string secao { get; set; }

        public bool desconto_sindicato { get; set; }

        [Display(Name = "Tamanho da camisa")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string tamanho_camisa { get; set; }

        [Display(Name = "Tamanho da calça")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string tamanho_calca { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Observações")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string observacoes { get; set; }

        //colocar upload de foto
        [Display(Name = "Foto")]
        public string foto { get; set; }

        [Display(Name = "Ativo?")]
        public bool ativo { get; set; }

        //Enum
        public TipoEstadoCivil TipoEstadoCivil { get; set; }

        public TipoGerencial TipoGerencial { get; set; }

        public TipoNacionalidade TipoNacionalidade { get; set; }

        public TipoSexo TipoSexo { get; set; }

        public TipoFuncionario TipoFuncionario { get; set; }

        
        

        //Relações do EF
        public IEnumerable <Bancos> Bancos { get; set; }

        public IEnumerable<Familiares> Familiares { get; set; }

        public IEnumerable<HistoricoFerias> HistoricoFerias { get; set; }

        public IEnumerable<HistoricoFuncionario> HistoricoFuncionario { get; set; }

        public IEnumerable<HistoricoSalario> HistoricoSalario { get; set; }

        public IEnumerable<Eventos> Eventos { get; set; }

        public Admissao Admissao { get; set; }

        public Cargos Cargos { get; set; }

        public Divisao Divisao { get; set; }

        public EnderecoFuncionario EnderecoFuncionario { get; set; }


        public HorariosAtuais HorariosAtuais { get; set; }

        public HorariosOriginais HorariosOriginais { get; set; }

        public Instrucao Instrucao { get; set; }

        public Lojas Lojas { get; set; }

        public MotivosAfastamento MotivosAfastamento { get; set; }

        public PlanoDeSaude PlanoDeSaude { get; set; }

        public Salarios Salarios { get; set; }

        public TarifasDeOnibus TarifasDeOnibus { get; set; }

        public UnidadeDeFederacao UnidadeDeFederacao { get; set; }



    }
}
