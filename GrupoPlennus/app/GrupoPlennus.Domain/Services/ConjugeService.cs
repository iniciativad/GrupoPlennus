using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Services
{
    public class ConjugeService : ServiceBase<Conjuge>, IConjugeService
    {
        private readonly IConjugeRepository _conjugeRepository;

        public ConjugeService(IConjugeRepository conjugeRepository)
            : base(conjugeRepository)
        {
            _conjugeRepository = conjugeRepository;
        }


        public IEnumerable<Conjuge> BuscaPorCpf(string cpf)
        {
            return _conjugeRepository.BuscaPorCpf(cpf);
        }

       

        public IEnumerable<Conjuge> BuscaPorNome(string nome)
        {
            return _conjugeRepository.BuscaPorNome(nome);
        }

        public IEnumerable<Conjuge> BuscaPorResponsavel(int pessoaId)
        {
            return _conjugeRepository.BuscaPorResponsavel(pessoaId);
        }
    }
}
