using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Application
{
    public class ResidenciaAtualAppService : AppServiceBase<ResidenciaAtual>, IResidenciaAtualAppService
    {
        private readonly IResidenciaAtualService _residenciaService;
        public ResidenciaAtualAppService(IResidenciaAtualService residenciaService)
            : base(residenciaService)
        {
            _residenciaService = residenciaService;
        }
    }
}
