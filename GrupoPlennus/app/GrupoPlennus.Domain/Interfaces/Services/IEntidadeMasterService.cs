using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Interfaces.Services
{
    public interface IEntidadeMasterService : IServiceBase<EntidadeMaster>
    {
        IEnumerable<EntidadeMaster> BuscaPorNome(string nome);
    }
}
