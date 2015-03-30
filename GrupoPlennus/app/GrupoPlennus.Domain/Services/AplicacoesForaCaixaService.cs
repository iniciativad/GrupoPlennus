using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;


namespace GrupoPlennus.Domain.Services
{
    public class AplicacoesForaCaixaService : ServiceBase<AplicacoesForaCaixa>, IAplicacoesForaCaixaService
    {
        private readonly IAplicacoesForaCaixaRepository _aplicacoesForaCaixaRepository;
        public AplicacoesForaCaixaService(IAplicacoesForaCaixaRepository aplicacoesForaCaixaRepository)
            :base(aplicacoesForaCaixaRepository)
        {
            _aplicacoesForaCaixaRepository = aplicacoesForaCaixaRepository;
        }
    }
}
