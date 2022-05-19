using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class PlanoDeSaude : Entity
    {
        public Guid FuncionarioId { get; set; }



        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Nome do plano")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string plano { get; set; }

        
        
        //Relação do EF

        public Funcionario funcionario { get; set; }
    }
}
