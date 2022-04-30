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
        public DbSet<RH_DELIRIO.Models.Admissao> Admissao { get; set; }
        public DbSet<RH_DELIRIO.Models.Bancos> Bancos { get; set; }
        public DbSet<RH_DELIRIO.Models.Cargos> Cargos { get; set; }
        public DbSet<RH_DELIRIO.Models.Divisao> Divisao { get; set; }
        public DbSet<RH_DELIRIO.Models.EnderecoFuncionario> EnderecoFuncionario { get; set; }
        public DbSet<RH_DELIRIO.Models.EnderecoLojas> EnderecoLojas { get; set; }
        public DbSet<RH_DELIRIO.Models.EstadoCivil> EstadoCivil { get; set; }
        public DbSet<RH_DELIRIO.Models.Eventos> Eventos { get; set; }
        public DbSet<RH_DELIRIO.Models.Familiares> Familiares { get; set; }
        public DbSet<RH_DELIRIO.Models.Funcionario> Funcionario { get; set; }
        public DbSet<RH_DELIRIO.Models.HistoricoFerias> HistoricoFerias { get; set; }
        public DbSet<RH_DELIRIO.Models.HistoricoFuncionario> HistoricoFuncionario { get; set; }
        public DbSet<RH_DELIRIO.Models.HistoricoSalario> HistoricoSalario { get; set; }
        public DbSet<RH_DELIRIO.Models.HorariosAtuais> HorariosAtuais { get; set; }
        public DbSet<RH_DELIRIO.Models.HorariosOriginais> HorariosOriginais { get; set; }
        public DbSet<RH_DELIRIO.Models.Instrucao> Instrucao { get; set; }
        public DbSet<RH_DELIRIO.Models.Lojas> Lojas { get; set; }
        public DbSet<RH_DELIRIO.Models.MotivosAfastamento> MotivosAfastamento { get; set; }
        public DbSet<RH_DELIRIO.Models.PlanoDeSaude> PlanoDeSaude { get; set; }
        public DbSet<RH_DELIRIO.Models.Salarios> Salarios { get; set; }
        public DbSet<RH_DELIRIO.Models.TarifasDeOnibus> TarifasDeOnibus { get; set; }
        public DbSet<RH_DELIRIO.Models.UnidadeDeFederacao> UnidadeDeFederacao { get; set; }
        
    }
}
