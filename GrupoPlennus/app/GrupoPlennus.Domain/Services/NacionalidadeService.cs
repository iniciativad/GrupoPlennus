using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Domain.Services
{
   public class NacionalidadeService :ServiceBase<Nacionalidade>,INacionalidadeService
    {
        private readonly INacionalidadeRepository _nacionalidadeRespository;
        public NacionalidadeService(INacionalidadeRepository nacionalidadeRespository)
            :base(nacionalidadeRespository)
        {
            _nacionalidadeRespository = nacionalidadeRespository;
        }
    }
}
