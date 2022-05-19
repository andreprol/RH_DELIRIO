using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class TarifasDeOnibus : Entity
    {
        public Guid FuncionarioId { get; set; }

        [Display(Name = "Tarifa original")]
        public int tarifa_original { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Tarifa atual")]
        public int tarifa_atual { get; set; }

        
        [Display(Name = "Tipo da tarifa")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string tipo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de modificação da tarifa")]
        public DateTime data_modificacao { get; set; }

        
        //Relação do EF

        public Funcionario funcionario { get; set; }
    }
}
