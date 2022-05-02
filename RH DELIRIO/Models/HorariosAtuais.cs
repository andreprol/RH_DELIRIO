using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class HorariosAtuais : Entity
    {
        public Guid FuncionarioId { get; set; }


        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de entrada - abertura")]
        public DateTime data_entrada_abertura { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de saída - abertura")]
        public DateTime data_saida_abertura { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de entrada - intermediária")]
        public DateTime data_entrada_inter { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de saída - intermediária")]
        public DateTime data_saida_inter { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de entrada - noite")]
        public DateTime data_entrada_noite { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de saída - noite")]
        public DateTime data_saida_noite { get; set; }

        

        //Relação do EF

        public Funcionario funcionario { get; set; }
    }
}
