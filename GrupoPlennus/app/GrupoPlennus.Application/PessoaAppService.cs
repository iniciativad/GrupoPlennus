using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace GrupoPlennus.Application
{
    public class PessoaAppService : AppServiceBase<Pessoa>, IPessoaAppService
    {
        public readonly IPessoaService _pessoaService;
        public PessoaAppService(IPessoaService pessoaService)
            : base(pessoaService)
        {
            _pessoaService = pessoaService;
        }
        public IEnumerable<Pessoa> BuscaPorCpf(string cpf)
        {
            return _pessoaService.BuscaPorCpf(cpf);
        }

        public IEnumerable<Pessoa> BuscaPorEntidade(int entidadeId)
        {
            return _pessoaService.BuscaPorEntiade(entidadeId);
        }

        public IEnumerable<Pessoa> BuscaPorNome(string nome)
        {
            return _pessoaService.BuscaPorNome(nome);
        }
    }
}
