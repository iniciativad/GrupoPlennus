using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GrupoPlennus.Data.Repositories
{
    public class DependenteRepository : RepositoryBase<Dependente>, IDependenteRepository
    {
        public IEnumerable<Dependente> BuscaPorCpf(string cpf)
        {
            return Db.Dependente.Where(d => d.Cpf == cpf);
        }

       

        public IEnumerable<Dependente> BuscaPorNome(string nome)
        {
            return Db.Dependente.Where(d => d.Nome == nome);
        }

        public IEnumerable<Dependente> BuscaPorResponsavel(int pessoaId)
        {
            return Db.Dependente.Where(d => d.PessoaId == pessoaId);
        }
    }
}
