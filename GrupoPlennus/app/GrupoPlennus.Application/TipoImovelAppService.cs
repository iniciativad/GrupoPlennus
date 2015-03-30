using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Application
{
   public class TipoImovelAppService :AppServiceBase<TipoImovel>,ITipoImovelAppService
    {
        private readonly ITipoImovelService _tipoImovelService;
        public TipoImovelAppService(ITipoImovelService tipoImovelService)
            :base(tipoImovelService)
        {
            _tipoImovelService = tipoImovelService;
        }
    }
}
