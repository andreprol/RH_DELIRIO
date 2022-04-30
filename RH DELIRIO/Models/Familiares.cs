﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class Familiares
    {
        [Key]
        public Guid Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Nome do pai")]
        public string nome_pai { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Nome da mãe")]
        public string nome_mae { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Nome do filho(a)")]
        public string nome_filho { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de nascimento do filho(a)")]
        public DateTime nasc_filho { get; set; }

        public Familiares()
        {
            Id = Guid.NewGuid();
        }
        public Familiares(string pai, string mae, string filho)
        {
            string nome_pai = pai;
            string nome_mae = mae;
            string nome_filho = filho;
        }

        public Familiares(string pai, string mae, string filho, DateTime nasc)
        {
            string nome_pai = pai;
            string nome_mae = mae;
            string nome_filho = filho;
            DateTime nasc_filho = nasc;
        }
    }
}
