using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class HistoricoSalario : Entity
    {
        public Guid FuncionarioId { get; set; }


        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de modificação de Salário")]
        public DateTime data_mod_salario { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Salário inicial")]
        public int salario_inicial { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Salário Atual")]
        public int salario_atual { get; set; }

       
        

        //Relação do EF

        public Funcionario funcionario { get; set; }
    }
}
