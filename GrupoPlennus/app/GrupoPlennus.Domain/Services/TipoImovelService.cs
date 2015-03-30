using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Domain.Services
{
   public class TipoImovelService :ServiceBase<TipoImovel>,ITipoImovelService
    {
        private readonly ITipoImovelRepository _tipoImovelRepository;
        public TipoImovelService(ITipoImovelRepository tipoImovelRepository)
            :base(tipoImovelRepository)
        {
            _tipoImovelRepository = tipoImovelRepository;
        }
    }
}
