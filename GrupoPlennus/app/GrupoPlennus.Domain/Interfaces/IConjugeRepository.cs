using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Interfaces
{
    public interface IConjugeRepository : IRepositoryBase<Conjuge>
    {
        IEnumerable<Conjuge> BuscaPorNome(string nome);
        IEnumerable<Conjuge> BuscaPorCpf(string cpf);
        IEnumerable<Conjuge> BuscaPorEntidade(int EntidadeId);
        IEnumerable<Conjuge> BuscaPorResponsavel(int pessoaId);
    }
}
