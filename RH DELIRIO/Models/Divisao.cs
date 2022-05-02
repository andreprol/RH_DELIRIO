using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class Divisao : Entity
    {
        public Guid FuncionarioId { get; set; }

        [Display(Name = "Nº da Divisão")]
        public int numero_divisao { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Descrição da Divisão")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string descricao { get; set; }

        
        
        //Relação do EF

        public Funcionario funcionario { get; set; }
    }
}
