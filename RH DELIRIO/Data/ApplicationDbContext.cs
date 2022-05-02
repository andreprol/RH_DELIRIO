using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RH_DELIRIO.Models;

namespace RH_DELIRIO.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Admissao> Admissoes { get; set; }

        public DbSet<Bancos> Bancos { get; set; }

        public DbSet<Cargos> Cargos { get; set; }

        public DbSet<Divisao> Divisoes { get; set; }

        public DbSet<EnderecoFuncionario> EnderecosFuncionarios { get; set; }

        public DbSet<EnderecoLojas> EnderecosLojas { get; set; }

        public DbSet<Eventos> Eventos { get; set; }

        public DbSet<Familiares> Familiares { get; set; }

        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<HistoricoFerias> HistoricosFerias { get; set; }

        public DbSet<HistoricoFuncionario> HistoricosFuncionarios { get; set; }

        public DbSet<HistoricoSalario> HistoricosSalarios { get; set; }

        public DbSet<HorariosAtuais> HorariosAtuais { get; set; }

        public DbSet<HorariosOriginais> HorariosOriginais { get; set; }

        public DbSet<Instrucao> Instrucoes { get; set; }

        public DbSet<Lojas> Lojas { get; set; }

        public DbSet<MotivosAfastamento> MotivosAfastamentos { get; set; }

        public DbSet<PlanoDeSaude> PlanosDeSaude { get; set; }

        public DbSet<Salarios> Salarios { get; set; }

        public DbSet<TarifasDeOnibus> TarifasDeOnibus { get; set; }

        public DbSet<RH_DELIRIO.Models.UnidadeDeFederacao> UnidadeDeFederacao { get; set; }



    }
}
