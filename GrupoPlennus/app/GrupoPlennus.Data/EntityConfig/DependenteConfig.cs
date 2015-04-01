using GrupoPlennus.Domain.Entities;
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

           

            Property(p => p.Cpf)
                .HasMaxLength(11)                
                .HasColumnType("Char");

           
        }
    }
}
