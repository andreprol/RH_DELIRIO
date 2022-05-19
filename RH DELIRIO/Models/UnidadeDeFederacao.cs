using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class UnidadeDeFederacao : Entity
    {
        public Guid FuncionarioId { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Estado")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string estado { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Sigla do Estado")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string sigla { get; set; }


        //Relações do EF
        public Funcionario funcionario { get; set; }

    }
}
