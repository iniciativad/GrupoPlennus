using System.Collections.Generic;

namespace GrupoPlennus.Domain.Listas
{
    public class Atividade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public IEnumerable<Atividade> Lista()
        {
            return new List<Atividade>
            {
                new Atividade{Id=0,Descricao="DESEMPREGADO"},
                new Atividade{Id=1,Descricao="ASSALARIADO"},
                new Atividade{Id=2,Descricao="AUTONOMO"},
                new Atividade{Id=3,Descricao="EMPRESARIO"},
                new Atividade{Id=4,Descricao="FUNCIONARIO PUBLICO"},
                new Atividade{Id=5,Descricao="PROFISSIONAL LIBERAL"},
                new Atividade{Id=6,Descricao="APOSENTADO"},
                new Atividade{Id=7,Descricao="PENSIONISTA"},
                new Atividade{Id=8,Descricao="BENEFICIÁRIO DE PROGRAMAS SOCIAIS"}
            };
        }
    }
}
