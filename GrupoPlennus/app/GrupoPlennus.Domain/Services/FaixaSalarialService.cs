using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Domain.Services
{
    public class FaixaSalarialService : ServiceBase<FaixaSalarial>, IFaixaSalarialService
    {
        private readonly IFaixaSalarialRepository _faixaSalarialRepository;
        public FaixaSalarialService(IFaixaSalarialRepository faixaSalarialRepository)
            : base(faixaSalarialRepository)
        {
            _faixaSalarialRepository = faixaSalarialRepository;
        }
    }
}
