using System.Collections.Generic;

namespace GrupoPlennus.Domain.Listas
{
    public class Sexo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public List<Sexo> GetAll()
        {
            return new List<Sexo>
            {
                new Sexo {Id = 1, Descricao="Feminino" },
                new Sexo {Id = 2, Descricao="Masculino" }
            };
        }
    }
}
