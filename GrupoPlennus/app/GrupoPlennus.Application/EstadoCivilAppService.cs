using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Application
{
  public  class EstadoCivilAppService :AppServiceBase<EstadoCivil>,IEstadoCivilAppService
    {
        private readonly IEstadoCivilService _estadoCivilservice;
        public EstadoCivilAppService(IEstadoCivilService estadoCivilservice)
            :base(estadoCivilservice)
        {
            _estadoCivilservice = estadoCivilservice;
        }
    }
}
