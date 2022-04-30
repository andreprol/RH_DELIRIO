using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class HistoricoFuncionario : Entity
    {
        

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "A data é obrigatória")]
        [Display(Name = "Data da ocorrência")]
        public DateTime data { get; set; }

        [Required(ErrorMessage = "É necessário descrever o ocorrido")]
        [Display(Name = "Descrição da ocorrência")]
        public string descricao { get; set; }


        public HistoricoFuncionario(DateTime data_his, string descricao_ocorrencia)
        {
            DateTime data = data_his;
            string descricao = descricao_ocorrencia;
        }
    }
}
