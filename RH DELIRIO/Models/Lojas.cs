using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class Lojas : Entity
    {
        public Guid FuncionarioId { get; set; }



        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Nome da loja atual - descrição")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string descricaoAtual { get; set; }


        
        [Display(Name = "Nome da loja anterior - descrição")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string descricaoAnterior { get; set; }


        
        [Display(Name = "Nome da loja original - descrição")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string descricaoOriginal { get; set; }

        
        [Display(Name = "Sigla")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string sigla { get; set; }

       
        [Display(Name = "Razão Social")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string razao_social { get; set; }

        [Display(Name = "CNPJ")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string cnpj { get; set; }

        [Display(Name = "Inscrição Estadual")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string inscricao_estadual { get; set; }

        [Display(Name = "Cód Amil")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string cod_amil { get; set; }

        //Relacão do EF

        public Funcionario funcionario { get; set; }

    }
}
