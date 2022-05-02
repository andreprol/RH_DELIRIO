using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class MotivosAfastamento : Entity
    {
        public Guid FuncionarioId { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Required(ErrorMessage = "A descrição é obrigatória")]
        [Display(Name = "Motivo do afastamento - descrição")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string descricao { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "A data do afastamento é obrigatória")]
        [Display(Name = "Data do afastamento")]
        public DateTime data_afastamento { get; set; }

       
        //Relação do EF

        public Funcionario funcionario { get; set; }
    }
}
