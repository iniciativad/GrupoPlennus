using System.Collections.Generic;

namespace GrupoPlennus.Domain.Listas
{
    public class TipoImovel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public IEnumerable<TipoImovel> Lista()
        {
            return new List<TipoImovel>
            {
                new TipoImovel{Id=1,Descricao = "Casa"},
                new TipoImovel{Id=2,Descricao = "Terreno"},
                new TipoImovel{Id=3,Descricao = "Lote"},
                new TipoImovel{Id=4,Descricao = "Chácara"},
                new TipoImovel{Id=5,Descricao = "Apartamento"},
                new TipoImovel{Id=6,Descricao = "Loja"},
                new TipoImovel{Id=7,Descricao = "Sala Comercial"},
                new TipoImovel{Id=8,Descricao = "Fazenda"},
                new TipoImovel{Id=8,Descricao = "Não possui imóvel"}
            };
        }
    }
}
