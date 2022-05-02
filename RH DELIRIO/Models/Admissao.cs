using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class Admissao : Entity
    {
        public Guid FuncionarioId { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage ="Formato inválido")]
        [StringLength(200, ErrorMessage ="O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string tipo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage ="Data em formato incorreto")]
        [Required(ErrorMessage ="A data de admissão é obrigatória")]
        [Display(Name ="Data de admissão")]
        public DateTime data_admissao { get; set; }

        

        //Relação do EF

        public Funcionario funcionario { get; set; }
    }
}
