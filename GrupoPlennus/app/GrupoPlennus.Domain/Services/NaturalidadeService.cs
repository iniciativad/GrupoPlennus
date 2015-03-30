using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Domain.Services
{
    public class NaturalidadeService : ServiceBase<Naturalidade>, INaturalidadeService
    {
        private readonly INaturalidadeRepository _naturalidadeRepository;
        public NaturalidadeService(INaturalidadeRepository naturalidadeRepository)
            : base(naturalidadeRepository)
        {
            _naturalidadeRepository = naturalidadeRepository;
        }
    }
}
