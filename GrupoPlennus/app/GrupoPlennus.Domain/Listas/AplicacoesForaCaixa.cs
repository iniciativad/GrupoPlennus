using System.Collections.Generic;

namespace GrupoPlennus.Domain.Listas
{
    public class AplicacoesForaCaixa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public IEnumerable<AplicacoesForaCaixa> Lista()
        {
            return new List<AplicacoesForaCaixa>
            {
                new AplicacoesForaCaixa{Id=1,Descricao = "Empréstimo"},
                new AplicacoesForaCaixa{Id=2,Descricao = "Financiamento"},
                new AplicacoesForaCaixa{Id=3,Descricao = "Consórcio"},
                new AplicacoesForaCaixa{Id=4,Descricao = "Crediário"},
                new AplicacoesForaCaixa{Id=5,Descricao = "Plano de Saúde"},
                new AplicacoesForaCaixa{Id=6,Descricao = "Previdência"},
                new AplicacoesForaCaixa{Id=7,Descricao = "Internet/TvCabo/Jornais/Revistas"},
                new AplicacoesForaCaixa{Id=8,Descricao = "Seguro"},
                new AplicacoesForaCaixa{Id=9,Descricao = "Não Possui"}
            };
        }
    }
}
