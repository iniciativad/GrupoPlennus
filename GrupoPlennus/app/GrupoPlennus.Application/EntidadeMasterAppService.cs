using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace GrupoPlennus.Application
{
    public class EntidadeMasterAppService : AppServiceBase<EntidadeMaster>, IEntidadeMasterAppService
    {
        public readonly IEntidadeMasterService _entidadeService;
        public EntidadeMasterAppService(IEntidadeMasterService entidadeService)
            : base(entidadeService)
        {
            _entidadeService = entidadeService;
        }

        public IEnumerable<EntidadeMaster> BuscaPorNome(string nome)
        {
            return _entidadeService.BuscaPorNome(nome);
        }
    }
}
