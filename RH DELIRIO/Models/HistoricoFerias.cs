using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class HistoricoFerias : Entity
    {
        public Guid FuncionarioId { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Data de início")]
        public DateTime datainicio { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Data de fim")]
        public DateTime datafim { get; set; }

        [Display(Name = "Data de gozo")]
        public DateTime datagozo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Valor das férias")]
        public int valorferias { get; set; }

        [Display(Name = "Valor do abono")]
        public int abonoferias { get; set; }

        [Display(Name = "Qtd dias de gozo")]
        public int diasgozo { get; set; }

        [Display(Name = "Qtd dias vendidos")]
        public int diasvendidos { get; set; }

        [Display(Name = "Valor vendido")]
        public int valorvendido { get; set; }

        
        //Relação do EF

        public Funcionario funcionario { get; set; }
    }
}
