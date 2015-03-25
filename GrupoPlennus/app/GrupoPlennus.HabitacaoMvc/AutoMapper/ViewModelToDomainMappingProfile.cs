using AutoMapper;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.HabitacaoMvc.ViewModels;

namespace GrupoPlennus.HabitacaoMvc.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        protected override void Configure()
        {
          
            Mapper.CreateMap<Conjuge, ConjugeViewModel>();
            Mapper.CreateMap<Dependente, DependenteViewModel>();
            Mapper.CreateMap<Entidade, EntidadeViewModel>();
            Mapper.CreateMap<EntidadeMaster, EntidadeMasterViewModel>();
            Mapper.CreateMap<EntidadeTipos, EntidadeTiposViewModel>();
            Mapper.CreateMap<Pessoa, PessoaViewModel>();
          
        }
    }
}