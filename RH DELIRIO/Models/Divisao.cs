﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Models
{
    public class Divisao : Entity
    {

        [Display(Name = "Nº da Divisão")]
        public int numero_divisao { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Descrição da Divisão")]
        public string descricao { get; set; }

        
        public Divisao(int numero, string desc)
        {
            int numero_divisao = numero;
            string descricao = desc;
        }
    }
}
