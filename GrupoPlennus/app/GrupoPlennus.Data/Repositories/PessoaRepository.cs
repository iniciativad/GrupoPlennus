using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GrupoPlennus.Data.Repositories
{
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        public IEnumerable<Pessoa> BuscaPorCpf(string cpf)
        {
            return Db.Pessoa.Where(p => p.Cpf == cpf);
        }

        public IEnumerable<Pessoa> BuscaPorEntidade(int entidadeId)
        {
            return Db.Pessoa.Where(p => p.EntidadeId == entidadeId);
        }

      

        public IEnumerable<Pessoa> BuscaPorNis(string nis)
        {
            return Db.Pessoa.Where(p => p.Nis == nis);
        }

        public IEnumerable<Pessoa> BuscaPorNome(string nome)
        {
            return Db.Pessoa.Where(p => p.Nome == nome);
        }
    }
}
