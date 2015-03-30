using System.Collections.Generic;

namespace GrupoPlennus.Domain.Listas
{
    public class EstadoCivil
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public IEnumerable<EstadoCivil> GetAll()
        {
            return new List<EstadoCivil>
            {
                new EstadoCivil {Id = 1, Descricao = "Solteiro(a)"},
                new EstadoCivil {Id = 2, Descricao = "Casado(a) comunhão de bens"},
                new EstadoCivil {Id = 3, Descricao = "Casado(a) comunhão parcial de bens"},
                new EstadoCivil {Id = 4, Descricao = "Casado(a) separação de bens"},
                new EstadoCivil {Id = 5, Descricao = "Divorciado(a)"},
                new EstadoCivil {Id = 6, Descricao = "Separado(a) judicialmente"},
                new EstadoCivil {Id = 7, Descricao = "Viúvo(a)"},
                new EstadoCivil {Id = 8, Descricao = "União Estável/Outros"},
            };
        }
    }
}
