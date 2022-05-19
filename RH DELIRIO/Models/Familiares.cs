using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class Familiares : Entity
    {
        public Guid FuncionarioId { get; set; }

        
        [Display(Name = "Nome do pai")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string nome_pai { get; set; }

        
        [Display(Name = "Nome da mãe")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string nome_mae { get; set; }

        
        [Display(Name = "Nome do filho(a)")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string nome_filho { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de nascimento do filho(a)")]
        public DateTime nasc_filho { get; set; }


        //Relação do EF

        public Funcionario funcionario { get; set; }
    }
}
