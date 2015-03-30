using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Domain.Services
{
  public  class AtividadeService :ServiceBase<Atividade>,IAtividadeService
    {
        private readonly IAtividadeRepository _atividadeRepository;
        public AtividadeService(IAtividadeRepository atividadeRepository)
            :base(atividadeRepository)
        {
            _atividadeRepository = atividadeRepository;
        }
    }
}
