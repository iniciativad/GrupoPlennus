using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Application
{
   public class FaixaSalarialAppService :AppServiceBase<FaixaSalarial>, IFaixaSalarialAppService
    {
        private readonly IFaixaSalarialService _faixaSalarialService;
        public FaixaSalarialAppService(IFaixaSalarialService faixaSalarialService)
            :base(faixaSalarialService)
        {
            _faixaSalarialService = faixaSalarialService;
        }
    }
}
