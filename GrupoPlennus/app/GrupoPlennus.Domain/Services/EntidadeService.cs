using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Services
{
    public class EntidadeService : ServiceBase<Entidade>, IEntidadeService
    {
        private readonly IEntidadeRepository _entidadeRepository;
        public EntidadeService(IEntidadeRepository entidadeRepository)
            : base(entidadeRepository)
        {
            _entidadeRepository = entidadeRepository;
        }

        public IEnumerable<Entidade> BuscaPorEntidadeMaster(int entidadeMasterId)
        {
            return _entidadeRepository.BuscaPorEntidadeMaster(entidadeMasterId);
        }

        public IEnumerable<Entidade> BuscaPorNome(string nome)
        {
            return _entidadeRepository.BuscaPorNome(nome);
        }
    }
}
