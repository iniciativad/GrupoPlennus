﻿using GrupoPlennus.Data.EntityConfig;
using GrupoPlennus.Domain.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;

namespace GrupoPlennus.Data.Contexts
{
    public class PlennusContext : DbContext
    {
        public PlennusContext()
            : base("PlennusAC")
        {

        }

        public DbSet<Conjuge> Conjuge { get; set; }
        public DbSet<Dependente> Dependente { get; set; }
        public DbSet<Entidade> Entidade { get; set; }
        public DbSet<EntidadeMaster> EntidadeMaster { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<EntidadeTipos> EntidadeTipos { get; set; }
        public DbSet<Sexo> Sexo { get; set; }

        public DbSet<AplicacoesForaCaixa> AplicacoesForaCaixa { get; set; }
        public DbSet<Atividade> Atividade { get; set; }
        public DbSet<DocumentosComplementares> DocumentosComplementares { get; set; }
        public DbSet<EstadoCivil> EstadoCivil { get; set; }
        public DbSet<GrauInstrucao> GrauInstrucao { get; set; }
        public DbSet<Nacionalidade> Nacionalidade { get; set; }
        public DbSet<Naturalidade> Naturalidade { get; set; }
        public DbSet<ResidenciaAtual> ResidenciaAtual { get; set; }
        public DbSet<TipoImovel> TipoImovel { get; set; }
        public DbSet<TipoVeiculo> TipoVeiculo { get; set; }
        public DbSet<FaixaSalarial> FaixaSalarial { get; set; }
        public DbSet<Renda> Renda { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();



            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(75));


            modelBuilder.Configurations.Add(new ConjugeConfig());
            modelBuilder.Configurations.Add(new DependenteConfig());
            modelBuilder.Configurations.Add(new EntidadeConfig());
            modelBuilder.Configurations.Add(new EntidadeMasterConfig());
            modelBuilder.Configurations.Add(new PessoaConfig());


        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                var newException = new FormattedDbEntityValidationException(e);
                throw newException;
            }
        }

    }
}
