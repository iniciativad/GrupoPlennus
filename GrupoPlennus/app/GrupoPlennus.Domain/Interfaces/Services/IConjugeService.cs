using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Interfaces.Services
{
    public interface IConjugeService : IServiceBase<Conjuge>
    {
        IEnumerable<Conjuge> BuscaPorNome(string nome);
        IEnumerable<Conjuge> BuscaPorCpf(string cpf);
      
        IEnumerable<Conjuge> BuscaPorResponsavel(int pessoaId);
    }
}
