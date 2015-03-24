using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Application.Interfaces
{
    public interface IEntidadeAppService :IAppServiceBase<Entidade>
    {
        IEnumerable<Entidade> BuscaPorNome(string nome);
        IEnumerable<Entidade> BuscaPorEntidadeMaster(int entidadeMasterId);
    }
}
