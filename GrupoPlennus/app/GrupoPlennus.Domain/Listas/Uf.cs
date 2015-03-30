using System.Collections.Generic;

namespace GrupoPlennus.Domain.Listas
{
    public class Uf
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public List<Uf> GetAll()
        {
            return new List<Uf>
            {
                new Uf {Id = 1, Descricao="AC" },
                new Uf {Id = 2, Descricao="AL" },
                new Uf {Id = 3, Descricao="AM" },
                new Uf {Id = 4, Descricao="AP" },
                new Uf {Id = 5, Descricao="BA" },
                new Uf {Id = 6, Descricao="CE" },
                new Uf {Id = 7, Descricao="DF" },
                new Uf {Id = 8, Descricao="ES" },
                new Uf {Id = 9, Descricao="GO" },
                new Uf {Id = 10, Descricao="MA" },
                new Uf {Id = 11, Descricao="MG" },
                new Uf {Id = 12, Descricao="MS" },
                new Uf {Id = 13, Descricao="MT" },
                new Uf {Id = 14, Descricao="PA" },
                new Uf {Id = 15, Descricao="PB" },
                new Uf {Id = 16, Descricao="PE" },
                new Uf {Id = 17, Descricao="PI" },
                new Uf {Id = 18, Descricao="PR" },
                new Uf {Id = 19, Descricao="RJ" },
                new Uf {Id = 20, Descricao="RN" },
                new Uf {Id = 21, Descricao="RS" },
                new Uf {Id = 22, Descricao="RO" },
                new Uf {Id = 23, Descricao="RR" },
                new Uf {Id = 24, Descricao="SC" },
                new Uf {Id = 25, Descricao="SP" },
                new Uf {Id = 26, Descricao="SE" },
                new Uf {Id = 27, Descricao="TO" },

            };
        }
    }
}
