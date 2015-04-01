using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Domain.Services
{
  public  class RendaService :ServiceBase<Renda>,IRendaService
    {
        private readonly IRendaRepository _rendaRepository;
        public RendaService(IRendaRepository rendaRepository)
            :base(rendaRepository)
        {
            _rendaRepository = rendaRepository;
        }
    }
}
