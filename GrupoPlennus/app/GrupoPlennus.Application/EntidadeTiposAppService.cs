using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Application
{
    public class EntidadeTiposAppService : AppServiceBase<EntidadeTipos>, IEntidadeTiposAppService
    {
        private readonly IEntidadeTiposService _entidadeTiposService;
        public EntidadeTiposAppService(IEntidadeTiposService entidadeTiposService)
            : base(entidadeTiposService)
        {
            _entidadeTiposService = entidadeTiposService;
        }
    }
}
