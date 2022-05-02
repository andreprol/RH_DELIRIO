using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class UnidadeDeFederacao : Entity
    {

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Required(ErrorMessage ="O campo Estado é obrigatório")]
        [Display(Name = "Estado")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string estado { get; set; }

        [Required(ErrorMessage = "O campo Sigla é obrigatório")]
        [Display(Name = "Sigla do Estado")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string sigla { get; set; }


        //Relações do EF
        public IEnumerable<Funcionario> Funcionario { get; set; }

    }
}
