using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Application.Interfaces
{
    public interface IEntidadeMasterAppService : IAppServiceBase<EntidadeMaster>
    {
        IEnumerable<EntidadeMaster> BuscaPorNome(string nome);
       
    }
}
