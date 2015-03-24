using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Interfaces.Services
{
    public interface IEntidadeMasterService : IServiceBase<Entidade>
    {
        IEnumerable<EntidadeMaster> BuscaPorNome(string nome);
    }
}
