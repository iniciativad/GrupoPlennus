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
            Mapper.CreateMap<Sexo, SexoViewModel>();

            Mapper.CreateMap <AplicacoesForaCaixa, AplicacoesForaCaixaViewModel> ();
            Mapper.CreateMap <DocumentosComplementares, DocumentosComplementaresViewModel> ();
            Mapper.CreateMap <EstadoCivil, EstadoCivilViewModel> ();
            Mapper.CreateMap <GrauInstrucao, GrauInstrucaoViewModel> ();
            Mapper.CreateMap <Nacionalidade, NacionalidadeViewModel> ();
            Mapper.CreateMap <Naturalidade, NaturalidadeViewModel> ();
            Mapper.CreateMap <ResidenciaAtual, ResidenciaAtualViewModel> ();
            Mapper.CreateMap <TipoImovel, TipoImovel> ();
            Mapper.CreateMap <TipoVeiculo, TipoVeiculoViewModel> ();

        }
    }
}