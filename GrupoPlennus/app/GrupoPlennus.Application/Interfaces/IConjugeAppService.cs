using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Application.Interfaces
{
    public interface IConjugeAppService : IAppServiceBase<Conjuge>
    {
        IEnumerable<Conjuge> BuscaPorNome(string nome);
        IEnumerable<Conjuge> BuscaPorCpf(string cpf);
      
        IEnumerable<Conjuge> BuscaPorResponsavel(int pessoaId);
    }
}
