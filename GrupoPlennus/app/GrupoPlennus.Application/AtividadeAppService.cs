using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Application
{
  public  class AtividadeAppService :AppServiceBase<Atividade>,IAtividadeAppService
    {
        private readonly IAtividadeService _atividadeService;
        public AtividadeAppService(IAtividadeService atividadeService)
            :base(atividadeService)
        {
            _atividadeService = atividadeService;
        }
    }
}
