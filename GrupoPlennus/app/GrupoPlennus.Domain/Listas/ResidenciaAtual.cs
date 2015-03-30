using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoPlennus.Domain.Listas
{
    public class ResidenciaAtual
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public IEnumerable<ResidenciaAtual> Lista()
        {
            return new List<ResidenciaAtual>
            {
                new ResidenciaAtual{Id =1,Descricao = "Alugada"},
                new ResidenciaAtual{Id =2,Descricao = "Mora com parentes/pais"},
                new ResidenciaAtual{Id =3,Descricao = "Outros"},
                new ResidenciaAtual{Id =4,Descricao = "Cedida/Funcional"},
                new ResidenciaAtual{Id =5,Descricao = "Própria quitada"},
                new ResidenciaAtual{Id =6,Descricao = "Financiada pela CAIXA"},
                new ResidenciaAtual{Id =7,Descricao = "Financiada por outras entidades"}
            };
        }
    }
}
