using System.Collections.Generic;

namespace GrupoPlennus.Domain.Listas
{
    public class GrauInstrucao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public IEnumerable<GrauInstrucao> Lista()
        {
            return new List<GrauInstrucao>
            {
                new GrauInstrucao{Id=0,Descricao = "Não Alfabetizado"},
                new GrauInstrucao{Id=1,Descricao = "Ensino Fundamental Incompleto"},
                new GrauInstrucao{Id=2,Descricao = "Ensino Fundamental Completo"},
                new GrauInstrucao{Id=3,Descricao = "Médio Incompleto"},
                new GrauInstrucao{Id=4,Descricao = "Médio Completo"},
                new GrauInstrucao{Id=5,Descricao = "Superior Incompleto"},
                new GrauInstrucao{Id=6,Descricao = "Superior Completo"},
                new GrauInstrucao{Id=7,Descricao = "Especialização"},
                new GrauInstrucao{Id=8,Descricao = "Mestrado"},
                new GrauInstrucao{Id=9,Descricao = "Doutorado"},
            };
        }
    }
}
