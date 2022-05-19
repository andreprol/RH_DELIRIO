using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class HistoricoFuncionario : Entity
    {
        public Guid FuncionarioId { get; set; }


        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Data da ocorrência")]
        public DateTime data { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Descrição da ocorrência")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string descricao { get; set; }


        

        //Relação do EF

        public Funcionario funcionario { get; set; }
    }
}
