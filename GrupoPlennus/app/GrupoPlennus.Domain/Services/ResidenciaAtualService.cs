using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;
namespace GrupoPlennus.Domain.Services
{
  public  class ResidenciaAtualService :ServiceBase<ResidenciaAtual>,IResidenciaAtualService
    {
        private readonly IResidenciaAtualRepository _residenciaAtualRepository;
        public ResidenciaAtualService(IResidenciaAtualRepository residenciaAtualRepository)
            :base(residenciaAtualRepository)
        {
            _residenciaAtualRepository = residenciaAtualRepository;
        }
    }
}
