using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Services
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        public PessoaService(IPessoaRepository pessoaRepository)
            : base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
        public IEnumerable<Pessoa> BuscaPorCpf(string cpf)
        {
            return _pessoaRepository.BuscaPorCpf(cpf);
        }

        public IEnumerable<Pessoa> BuscaPorEntiade(int entidadeId)
        {
            return _pessoaRepository.BuscaPorEntidade(entidadeId);
        }

       

        public IEnumerable<Pessoa> BuscaPorNome(string nome)
        {
            return _pessoaRepository.BuscaPorNome(nome);
        }
    }
}
