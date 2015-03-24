using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace GrupoPlennus.Application
{
    public class EntidadeAppService : AppServiceBase<Entidade>, IEntidadeAppService
    {
        public readonly IEntidadeService _entidadeService;
        public EntidadeAppService(IEntidadeService entidadeService)
            : base(entidadeService)
        {
            _entidadeService = entidadeService;
        }
        public IEnumerable<Entidade> BuscaPorEntidadeMaster(int entidadeMasterId)
        {
            return _entidadeService.BuscaPorEntidadeMaster(entidadeMasterId);
        }

        public IEnumerable<Entidade> BuscaPorNome(string nome)
        {
            return _entidadeService.BuscaPorNome(nome);
        }
    }
}
