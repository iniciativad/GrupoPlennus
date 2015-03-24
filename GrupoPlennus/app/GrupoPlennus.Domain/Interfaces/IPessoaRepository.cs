using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Interfaces
{
    public interface IPessoaRepository : IRepositoryBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscaPorNome(string nome);
        IEnumerable<Pessoa> BuscaPorCpf(string cpf);
        IEnumerable<Pessoa> BuscaPorNis(string nis);
        IEnumerable<Pessoa> BuscaPorEntidade(int entidadeId);
    }
}
