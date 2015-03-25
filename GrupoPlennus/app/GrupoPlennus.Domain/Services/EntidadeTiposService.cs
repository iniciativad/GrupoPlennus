using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Domain.Services
{
    public class EntidadeTiposService :ServiceBase<EntidadeTipos>, IEntidadeTiposService
    {
        private readonly IEntidadeTiposRepository _entidadeTiposRepository;
        public EntidadeTiposService(IEntidadeTiposRepository entidadeTiposRepository)
            :base(entidadeTiposRepository)
        {
            _entidadeTiposRepository = entidadeTiposRepository;
        }
    }
}
