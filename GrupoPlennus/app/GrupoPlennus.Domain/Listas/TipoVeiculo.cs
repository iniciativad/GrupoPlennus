using System.Collections.Generic;

namespace GrupoPlennus.Domain.Listas
{
    public class TipoVeiculo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public IEnumerable<TipoVeiculo> Lista()
        {
            return new List<TipoVeiculo>
            {
                new TipoVeiculo{Id=1,Descricao="Carro"},
                new TipoVeiculo{Id=2,Descricao="Ônibus"},
                new TipoVeiculo{Id=3,Descricao="Motocicleta"},
                new TipoVeiculo{Id=4,Descricao="Utilitario"},
                new TipoVeiculo{Id=5,Descricao="Caminhão"},
                new TipoVeiculo{Id=6,Descricao="Embarcação"},
                new TipoVeiculo{Id=7,Descricao="Aeronave"},
                new TipoVeiculo{Id=8,Descricao="Não possui veículo"}
            };
        }
    }
}
