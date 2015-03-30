using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Application
{
   public class AplicacoesForaCaixaAppService :AppServiceBase<AplicacoesForaCaixa>,IAplicacoesForaCaixaAppService
    {
        private readonly IAplicacoesForaCaixaService _aplicacoesForaCaixaService;
        public AplicacoesForaCaixaAppService(IAplicacoesForaCaixaService aplicacoesForaCaixaService)
            :base(aplicacoesForaCaixaService)
        {
            _aplicacoesForaCaixaService = aplicacoesForaCaixaService;
        }
    }
}
