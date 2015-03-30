using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Domain.Services
{
   public class EstadoCivilService :ServiceBase<EstadoCivil>,IEstadoCivilService
    {
        private readonly IEstadoCivilRepository _estadoCivilRepository;
        public EstadoCivilService(IEstadoCivilRepository estadoCivilRepository)
            :base(estadoCivilRepository)
        {
            _estadoCivilRepository = estadoCivilRepository;
        }
    }
}
