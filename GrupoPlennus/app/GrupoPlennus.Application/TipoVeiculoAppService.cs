using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Application
{
    public class TipoVeiculoAppService : AppServiceBase<TipoVeiculo>, ITipoVeiculoAppService
    {
        private readonly ITipoVeiculoService _tipoVeiculoService;
        public TipoVeiculoAppService(ITipoVeiculoService tipoVeiculoService)
            : base(tipoVeiculoService)
        {
            _tipoVeiculoService = tipoVeiculoService;
        }
    }
}
