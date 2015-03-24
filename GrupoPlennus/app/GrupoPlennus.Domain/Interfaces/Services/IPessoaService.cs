using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Interfaces.Services
{
    public interface IPessoaService : IServiceBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscaPorNome(string nome);
        IEnumerable<Pessoa> BuscaPorCpf(string cpf);
        IEnumerable<Pessoa> BuscaPorEntiade(int entidadeId);
    }
}
