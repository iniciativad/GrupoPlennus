using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Application.Interfaces
{
    public interface IDependenteAppService : IAppServiceBase<Dependente>
    {
        IEnumerable<Dependente> BuscaPorNome(string nome);
        IEnumerable<Dependente> BuscaPorCpf(string cpf);
        
        IEnumerable<Dependente> BuscaPorResponsavel(int pessoaId);
    }
}
