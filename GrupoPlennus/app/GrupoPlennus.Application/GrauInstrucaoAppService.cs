using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;
namespace GrupoPlennus.Application
{
    public class GrauInstrucaoAppService : AppServiceBase<GrauInstrucao>, IGrauInstrucaoAppService
    {
        private readonly IGrauInstrucaoService _grauInstrucaoService;
        public GrauInstrucaoAppService(IGrauInstrucaoService grauInstrucaoService)
            : base(grauInstrucaoService)
        {
            _grauInstrucaoService = grauInstrucaoService;
        }
    }
}
