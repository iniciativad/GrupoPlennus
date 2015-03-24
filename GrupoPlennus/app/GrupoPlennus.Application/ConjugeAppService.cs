using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace GrupoPlennus.Application
{
    public class ConjugeAppService : AppServiceBase<Conjuge>, IConjugeAppService
    {
        private readonly IConjugeService _conjugeService;
        public ConjugeAppService(IConjugeService conjugeService)
            : base(conjugeService)
        {
            _conjugeService = conjugeService;
        }
        public IEnumerable<Conjuge> BuscaPorCpf(string cpf)
        {
            return _conjugeService.BuscaPorCpf(cpf);
        }

      

        public IEnumerable<Conjuge> BuscaPorNome(string nome)
        {
            return _conjugeService.BuscaPorNome(nome);
        }

        public IEnumerable<Conjuge> BuscaPorResponsavel(int pessoaId)
        {
            return _conjugeService.BuscaPorResponsavel(pessoaId);
        }
    }
}
