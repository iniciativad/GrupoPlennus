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
            Mapper.CreateMap<SexoViewModel, Sexo>();
            Mapper.CreateMap<PessoaViewModel, Pessoa>();

            Mapper.CreateMap<AplicacoesForaCaixaViewModel, AplicacoesForaCaixa>();
            Mapper.CreateMap <AtividadeViewModel, Atividade> ();
            Mapper.CreateMap <DocumentosComplementaresViewModel, DocumentosComplementares> ();
            Mapper.CreateMap <EstadoCivilViewModel, EstadoCivil> ();
            Mapper.CreateMap <GrauInstrucaoViewModel, GrauInstrucao> ();
            Mapper.CreateMap <NacionalidadeViewModel, Nacionalidade> ();
            Mapper.CreateMap <NaturalidadeViewModel, Naturalidade> ();
            Mapper.CreateMap <ResidenciaAtualViewModel, ResidenciaAtual> ();
            Mapper.CreateMap <TipoImovelViewModel, TipoImovel> ();
            Mapper.CreateMap <TipoVeiculoViewModel, TipoVeiculo> ();
            Mapper.CreateMap<FaixaSalarialViewModel, FaixaSalarial>();


        }
    }
}