using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GrupoPlennus.Data.Repositories
{
    public class EntidadeRepository : RepositoryBase<Entidade>, IEntidadeRepository
    {
        public IEnumerable<Entidade> BuscaPorEntidadeMaster(int entidadeMasterId)
        {
            return Db.Entidade.Where(p => p.EntidadeMasterId == entidadeMasterId);
        }

        public IEnumerable<Entidade> BuscaPorNome(string nome)
        {
            return Db.Entidade.Where(p => p.NomeFantasia == nome);
        }
    }
}
