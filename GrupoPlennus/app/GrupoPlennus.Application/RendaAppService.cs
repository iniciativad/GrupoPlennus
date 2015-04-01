using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Application
{
   public class RendaAppService :AppServiceBase<Renda>,IRendaAppService
    {
        private readonly IRendaService _rendaService;
        public RendaAppService(IRendaService rendaService)
            :base(rendaService)
        {
            _rendaService = rendaService;
        }
    }
}
