using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Application
{
    public class NaturalidadeAppService :AppServiceBase<Naturalidade>,INaturalidadeAppService
    {
        private readonly INaturalidadeService _naturalidadeService;
        public NaturalidadeAppService(INaturalidadeService naturalidadeService)
            :base(naturalidadeService)
        {
            _naturalidadeService = naturalidadeService;
        }
    }
}
