using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class Salarios : Entity
    {
        public Guid FuncionarioId { get; set; }

        [Display(Name = "Cargo original - descrição")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string cargo_original { get; set; }

        [Display(Name = "Cargo atual - descição")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string cargo_atual { get; set; }

        [Display(Name = "Salário original")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public int salario_original { get; set; }

        [Required(ErrorMessage = "O salário atual é obrigatório")]
        [Display(Name = "Salário atual")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public int salario_atual { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de modificação de salário")]
        public DateTime data_modificao { get; set; }

       
        //Relação do EF

        public Funcionario funcionario { get; set; }
    }
}
