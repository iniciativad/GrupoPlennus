using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GrupoPlennus.Data.Repositories
{
    public class EntidadeMasterRepository : RepositoryBase<EntidadeMaster>, IEntidadeMasterRepository
    {
        public IEnumerable<EntidadeMaster> BuscaPorNome(string nome)
        {
            return Db.EntidadeMaster.Where(p => p.NomeFantasia == nome);
        }
    }
}
