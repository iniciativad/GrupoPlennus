using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Application
{
    public class SexoAppService :AppServiceBase<Sexo>, ISexoAppService
    {
        private readonly ISexoService _sexoService;
        public SexoAppService(ISexoService sexoService)
            :base(sexoService)
        {
            _sexoService = sexoService;
        }
    }
}
