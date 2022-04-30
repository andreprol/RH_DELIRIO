using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class PlanoDeSaude : Entity
    {
        

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Required(ErrorMessage = "O nome do plano é obrigatório")]
        [Display(Name = "Nome do plano")]
        public string plano { get; set; }

        
        public PlanoDeSaude(string plano_saude)
        {
            string plano = plano_saude;
        }

    }
}
