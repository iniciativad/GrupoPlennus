﻿using GrupoPlennus.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GrupoPlennus.Data.EntityConfig
{
    public class DependenteConfig : EntityTypeConfiguration<Dependente>
    {
        public DependenteConfig()
        {
            HasKey(p => p.Id);

            Property(p => p.Nome).
                IsRequired();

            Property(p => p.Email)
                .HasMaxLength(160);

            Property(p => p.Cpf)
                .HasMaxLength(11)
                .IsRequired()
                .HasColumnType("Char");

            Property(p => p.Cep)
                .HasMaxLength(8)
                .HasColumnType("Char");



            Property(p => p.Uf)
                .HasMaxLength(2)
                .HasColumnType("Char");
        }
    }
}