using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Domain.Services
{
  public  class GrauInstrucaoService :ServiceBase<GrauInstrucao>,IGrauInstrucaoService
    {
        private readonly IGrauInstrucaoRepository _grauInstrucaoRespository;
        public GrauInstrucaoService(IGrauInstrucaoRepository grauInstrucaoRespository)
            :base(grauInstrucaoRespository)
        {
            _grauInstrucaoRespository = grauInstrucaoRespository;
        }
    }
}
