namespace GrupoPlennus.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GrupoPlennus.Domain.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<Contexts.PlennusContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GrupoPlennus.Data.Contexts.PlennusContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.AplicacoesForaCaixa.AddOrUpdate(
               p => p.Id,
                new AplicacoesForaCaixa { Id = 1, Descricao = "Empréstimo" },
                new AplicacoesForaCaixa { Id = 2, Descricao = "Financiamento" },
                new AplicacoesForaCaixa { Id = 3, Descricao = "Consórcio" },
                new AplicacoesForaCaixa { Id = 4, Descricao = "Crediário" },
                new AplicacoesForaCaixa { Id = 5, Descricao = "Plano de Saúde" },
                new AplicacoesForaCaixa { Id = 6, Descricao = "Previdência" },
                new AplicacoesForaCaixa { Id = 7, Descricao = "Internet/TvCabo/Jornais/Revistas" },
                new AplicacoesForaCaixa { Id = 8, Descricao = "Seguro" },
                new AplicacoesForaCaixa { Id = 9, Descricao = "Não Possui" }
                );


            context.Atividade.AddOrUpdate(
                p => p.Id,
                new Atividade { Id = 1, Descricao = "DESEMPREGADO" },
                new Atividade { Id = 2, Descricao = "ASSALARIADO" },
                new Atividade { Id = 3, Descricao = "AUTONOMO" },
                new Atividade { Id = 4, Descricao = "EMPRESARIO" },
                new Atividade { Id = 5, Descricao = "FUNCIONARIO PUBLICO" },
                new Atividade { Id = 6, Descricao = "PROFISSIONAL LIBERAL" },
                new Atividade { Id = 7, Descricao = "APOSENTADO" },
                new Atividade { Id = 8, Descricao = "PENSIONISTA" },
                new Atividade { Id = 9, Descricao = "BENEFICIÁRIO DE PROGRAMAS SOCIAIS" }

                );

            context.DocumentosComplementares.AddOrUpdate(
                p => p.Id,
                new DocumentosComplementares { Id = 1, Descricao = "Água e Esgoto, Energia Elétrica, Telefone" },
                new DocumentosComplementares { Id = 2, Descricao = "Previdência, Consóricio, segura, Plano de Saúde" },
                new DocumentosComplementares { Id = 3, Descricao = "Não Apresentou Documentos" },
                new DocumentosComplementares { Id = 4, Descricao = "Fatura Cartão, Extrato C/C" },
                new DocumentosComplementares { Id = 5, Descricao = "TV a cabo, Internet, Assin. Revistas e jornais" }
                );

            context.EstadoCivil.AddOrUpdate(
                p => p.Id,
                new EstadoCivil { Id = 1, Descricao = "Solteiro(a)" },
                new EstadoCivil { Id = 2, Descricao = "Casado(a) comunhão de bens" },
                new EstadoCivil { Id = 3, Descricao = "Casado(a) comunhão parcial de bens" },
                new EstadoCivil { Id = 4, Descricao = "Casado(a) separação de bens" },
                new EstadoCivil { Id = 5, Descricao = "Divorciado(a)" },
                new EstadoCivil { Id = 6, Descricao = "Separado(a) judicialmente" },
                new EstadoCivil { Id = 7, Descricao = "Viúvo(a)" },
                new EstadoCivil { Id = 8, Descricao = "União Estável/Outros" }
                );

            context.GrauInstrucao.AddOrUpdate(
                p => p.Id,

                new GrauInstrucao { Id = 1, Descricao = "Ensino Fundamental Incompleto" },
                new GrauInstrucao { Id = 2, Descricao = "Ensino Fundamental Completo" },
                new GrauInstrucao { Id = 3, Descricao = "Médio Incompleto" },
                new GrauInstrucao { Id = 4, Descricao = "Médio Completo" },
                new GrauInstrucao { Id = 5, Descricao = "Superior Incompleto" },
                new GrauInstrucao { Id = 6, Descricao = "Superior Completo" },
                new GrauInstrucao { Id = 7, Descricao = "Especialização" },
                new GrauInstrucao { Id = 8, Descricao = "Mestrado" },
                new GrauInstrucao { Id = 9, Descricao = "Doutorado" },
                new GrauInstrucao { Id = 10, Descricao = "Não Alfabetizado" }
                );

            context.Nacionalidade.AddOrUpdate(
                p => p.Id,
                new Nacionalidade { Id = 1, Descricao = "Brasileira" },
                new Nacionalidade { Id = 2, Descricao = "Brasileira Naturalizado" },
                new Nacionalidade { Id = 3, Descricao = "Estrangeira" }

                );

            context.ResidenciaAtual.AddOrUpdate(
                p =>p.Id,
                new ResidenciaAtual { Id = 1, Descricao = "Alugada" },
                new ResidenciaAtual { Id = 2, Descricao = "Mora com parentes/pais" },
                new ResidenciaAtual { Id = 3, Descricao = "Outros" },
                new ResidenciaAtual { Id = 4, Descricao = "Cedida/Funcional" },
                new ResidenciaAtual { Id = 5, Descricao = "Própria quitada" },
                new ResidenciaAtual { Id = 6, Descricao = "Financiada pela CAIXA" },
                new ResidenciaAtual { Id = 7, Descricao = "Financiada por outras entidades" }

                );

            context.Sexo.AddOrUpdate(
                p => p.Id,
                new Sexo { Id = 1, Descricao = "Feminino" },
                new Sexo { Id = 2, Descricao = "Masculino" }
                );

            context.TipoImovel.AddOrUpdate(
                p=> p.Id,
                new TipoImovel { Id = 1, Descricao = "Casa" },
                new TipoImovel { Id = 2, Descricao = "Terreno" },
                new TipoImovel { Id = 3, Descricao = "Lote" },
                new TipoImovel { Id = 4, Descricao = "Chácara" },
                new TipoImovel { Id = 5, Descricao = "Apartamento" },
                new TipoImovel { Id = 6, Descricao = "Loja" },
                new TipoImovel { Id = 7, Descricao = "Sala Comercial" },
                new TipoImovel { Id = 8, Descricao = "Fazenda" },
                new TipoImovel { Id = 8, Descricao = "Não possui imóvel" }
                );

            context.TipoVeiculo.AddOrUpdate(
                p=> p.Id,
                new TipoVeiculo { Id = 1, Descricao = "Carro" },
                new TipoVeiculo { Id = 2, Descricao = "Ônibus" },
                new TipoVeiculo { Id = 3, Descricao = "Motocicleta" },
                new TipoVeiculo { Id = 4, Descricao = "Utilitario" },
                new TipoVeiculo { Id = 5, Descricao = "Caminhão" },
                new TipoVeiculo { Id = 6, Descricao = "Embarcação" },
                new TipoVeiculo { Id = 7, Descricao = "Aeronave" },
                new TipoVeiculo { Id = 8, Descricao = "Não possui veículo" }
                );

            context.Naturalidade.AddOrUpdate(
                p=> p.Id,
                new Naturalidade { Id = 1, Descricao = "AC" },
                new Naturalidade { Id = 2, Descricao = "AL" },
                new Naturalidade { Id = 3, Descricao = "AM" },
                new Naturalidade { Id = 4, Descricao = "AP" },
                new Naturalidade { Id = 5, Descricao = "BA" },
                new Naturalidade { Id = 6, Descricao = "CE" },
                new Naturalidade { Id = 7, Descricao = "DF" },
                new Naturalidade { Id = 8, Descricao = "ES" },
                new Naturalidade { Id = 9, Descricao = "GO" },
                new Naturalidade { Id = 10, Descricao = "MA" },
                new Naturalidade { Id = 11, Descricao = "MG" },
                new Naturalidade { Id = 12, Descricao = "MS" },
                new Naturalidade { Id = 13, Descricao = "MT" },
                new Naturalidade { Id = 14, Descricao = "PA" },
                new Naturalidade { Id = 15, Descricao = "PB" },
                new Naturalidade { Id = 16, Descricao = "PE" },
                new Naturalidade { Id = 17, Descricao = "PI" },
                new Naturalidade { Id = 18, Descricao = "PR" },
                new Naturalidade { Id = 19, Descricao = "RJ" },
                new Naturalidade { Id = 20, Descricao = "RN" },
                new Naturalidade { Id = 21, Descricao = "RS" },
                new Naturalidade { Id = 22, Descricao = "RO" },
                new Naturalidade { Id = 23, Descricao = "RR" },
                new Naturalidade { Id = 24, Descricao = "SC" },
                new Naturalidade { Id = 25, Descricao = "SP" },
                new Naturalidade { Id = 26, Descricao = "SE" },
                new Naturalidade { Id = 27, Descricao = "TO" }
                );
        }
    }
}
