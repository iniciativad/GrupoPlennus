using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Domain.Services
{
    public class TipoVeiculoService : ServiceBase<TipoVeiculo>, ITipoVeiculoService
    {
        private readonly ITipoVeiculoRepository _tipoVeiculoRepository;
        public TipoVeiculoService(ITipoVeiculoRepository tipoVeiculoRepository)
            : base(tipoVeiculoRepository)
        {
            _tipoVeiculoRepository = tipoVeiculoRepository;
        }
    }
}
