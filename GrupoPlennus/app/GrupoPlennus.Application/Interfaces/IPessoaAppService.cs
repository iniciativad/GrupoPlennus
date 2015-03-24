using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Application.Interfaces
{
    public interface IPessoaAppService : IAppServiceBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscaPorNome(string nome);
        IEnumerable<Pessoa> BuscaPorCpf(string cpf);
        IEnumerable<Pessoa> BuscaPorEntidade(int entidadeId);
    }
}
