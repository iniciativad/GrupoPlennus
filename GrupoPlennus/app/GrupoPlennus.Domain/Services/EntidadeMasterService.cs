using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Services
{
    public class EntidadeMasterService : ServiceBase<EntidadeMaster>, IEntidadeMasterService
    {
        private readonly IEntidadeMasterRepository _entidadeMasterRepository;
        public EntidadeMasterService(IEntidadeMasterRepository entidadeMasterRepository)
            : base(entidadeMasterRepository)
        {
            _entidadeMasterRepository = entidadeMasterRepository;
        }
        public IEnumerable<EntidadeMaster> BuscaPorNome(string nome)
        {
            return _entidadeMasterRepository.BuscaPorNome(nome);
        }
    }
}
