using GrupoPlennus.Domain.Entities;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Interfaces
{
    public interface IEntidadeRepository : IRepositoryBase<Entidade>
    {
        IEnumerable<Entidade> BuscaPorNome(string nome);
        IEnumerable<Entidade> BuscaPorEntidadeMaster(int entidadeMasterId);
    }
}
