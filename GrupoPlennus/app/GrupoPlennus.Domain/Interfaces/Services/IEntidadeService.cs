using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Interfaces.Services
{
    public interface IEntidadeService : IServiceBase<Entidade>
    {
        IEnumerable<Entidade> BuscaPorNome(string nome);
        IEnumerable<Entidade> BuscaPorEntidadeMaster(int entidadeMasterId);
    }
}
