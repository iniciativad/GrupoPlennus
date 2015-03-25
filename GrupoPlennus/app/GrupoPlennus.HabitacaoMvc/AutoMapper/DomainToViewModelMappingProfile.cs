using AutoMapper;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.HabitacaoMvc.ViewModels;

namespace GrupoPlennus.HabitacaoMvc.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }

        protected override void Configure()
        {
            
            Mapper.CreateMap<ConjugeViewModel, Conjuge>();
            Mapper.CreateMap<DependenteViewModel, Dependente>();
            Mapper.CreateMap<EntidadeViewModel, Entidade>();
            Mapper.CreateMap<EntidadeTiposViewModel, EntidadeTipos>();
            Mapper.CreateMap<EntidadeMasterViewModel, EntidadeMaster>();            
            Mapper.CreateMap<PessoaViewModel, Pessoa>();
           
           
        }
    }
}