using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Services
{
    public class DependenteService : ServiceBase<Dependente>, IDependenteService
    {
        private readonly IDependenteRepository _dependenteRepository;
        public DependenteService(IDependenteRepository dependenteRepository)
            : base(dependenteRepository)
        {
            _dependenteRepository = dependenteRepository;
        }
        public IEnumerable<Dependente> BuscaPorCpf(string cpf)
        {
            return _dependenteRepository.BuscaPorCpf(cpf);
        }

      

        public IEnumerable<Dependente> BuscaPorNome(string nome)
        {
            return _dependenteRepository.BuscaPorNome(nome);
        }

        public IEnumerable<Dependente> BuscaPorResponsavel(int pessoaId)
        {
            return _dependenteRepository.BuscaPorResponsavel(pessoaId);
        }
    }
}
