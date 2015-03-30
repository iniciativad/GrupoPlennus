using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;
namespace GrupoPlennus.Application
{
   public class NacionalidadeAppService :AppServiceBase<Nacionalidade>,INacionalidadeAppService
    {
        private readonly INacionalidadeService _nacionalidadeService;
        public NacionalidadeAppService(INacionalidadeService nacionalidadeService)
            :base(nacionalidadeService)
        {
            _nacionalidadeService = nacionalidadeService;
        }
    }
}
