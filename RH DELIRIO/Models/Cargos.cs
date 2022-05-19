using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class Cargos : Entity
    {
        public Guid FuncionarioId { get; set; }


        
        [Display(Name = "Abreviação")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string abreviacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Descrição do Cargo")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string descricao { get; set; }

        [Display(Name = "Dias de experiência")]
        public int diasexp { get; set; }

        [Display(Name = "Dias de prorrogação")]
        public int diasprorr { get; set; }

        //Relação do EF

        public Funcionario funcionario { get; set; }


    }
}
