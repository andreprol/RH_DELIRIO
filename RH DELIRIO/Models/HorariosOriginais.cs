﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class HorariosOriginais : Entity
    {
        

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

        public HorariosOriginais(DateTime entrada_abertura, DateTime saida_abertura, DateTime entrada_inter, 
            DateTime saida_inter, DateTime entrada_noite, DateTime saida_noite)
        {
            DateTime data_entrada_abertura = entrada_abertura;
            DateTime data_saida_abertura = saida_abertura;
            DateTime data_entrada_inter = entrada_inter;
            DateTime data_saida_inter = saida_inter;
            DateTime data_entrada_noite = entrada_noite;
            DateTime data_saida_noite = saida_noite;

        }
    }
}
