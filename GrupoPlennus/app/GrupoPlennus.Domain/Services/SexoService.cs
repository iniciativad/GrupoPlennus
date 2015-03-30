using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;


namespace GrupoPlennus.Domain.Services
{
    public class SexoService : ServiceBase<Sexo>, ISexoService
    {
        private readonly ISexoRepository _sexoRepository;
        public SexoService(ISexoRepository sexoRepository)
            :base(sexoRepository)
        {
            _sexoRepository = sexoRepository;
        }
    }
}
