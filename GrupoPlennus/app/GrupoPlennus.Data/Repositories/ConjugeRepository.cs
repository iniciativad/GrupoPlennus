using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GrupoPlennus.Data.Repositories
{
    public class ConjugeRepository : RepositoryBase<Conjuge>, IConjugeRepository
    {
        public IEnumerable<Conjuge> BuscaPorCpf(string cpf)
        {
            return Db.Conjuge.Where(c => c.Cpf == cpf);
        }

       

        public IEnumerable<Conjuge> BuscaPorNome(string nome)
        {
            return Db.Conjuge.Where(c => c.Nome == nome);
        }

        public IEnumerable<Conjuge> BuscaPorResponsavel(int pessoaId)
        {
            return Db.Conjuge.Where(c => c.PessoaId == pessoaId);
        }
    }
}
