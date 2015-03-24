using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Interfaces
{
    public interface IDependenteRepository : IRepositoryBase<Dependente>
    {
        IEnumerable<Dependente> BuscaPorNome(string nome);
        IEnumerable<Dependente> BuscaPorCpf(string cpf);
        IEnumerable<Dependente> BuscaPorEntidade(int entidadeId);
        IEnumerable<Dependente> BuscaPorResponsavel(int pessoaId);
    }
}
