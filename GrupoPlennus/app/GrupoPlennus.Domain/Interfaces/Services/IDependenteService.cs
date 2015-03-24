using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Interfaces.Services
{
    public interface IDependenteService : IServiceBase<Dependente>
    {
        IEnumerable<Dependente> BuscaPorNome(string nome);
        IEnumerable<Dependente> BuscaPorCpf(string cpf);
       
        IEnumerable<Dependente> BuscaPorResponsavel(int pessoaId);
    }
}
