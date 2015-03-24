using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Interfaces
{
    public interface IEntidadeMasterRepository :IRepositoryBase<EntidadeMaster>
    {
        IEnumerable<EntidadeMaster> BuscaPorNome(string nome);
    }
}
