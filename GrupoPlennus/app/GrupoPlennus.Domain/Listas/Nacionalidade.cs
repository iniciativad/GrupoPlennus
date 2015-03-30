using System.Collections.Generic;

namespace GrupoPlennus.Domain.Listas
{
    public class Nacionalidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public IEnumerable<Nacionalidade> GetAll()
        {
            return new List<Nacionalidade>
            {
                new Nacionalidade {Id = 1, Descricao = "Brasileira"},
                new Nacionalidade {Id = 2, Descricao = "Brasileira Naturalizado"},
                new Nacionalidade {Id = 3, Descricao = "Estrangeira"},

            };

        }
    }
}
