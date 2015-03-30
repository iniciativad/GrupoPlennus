using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace GrupoPlennus.HabitacaoMvc.ViewModels
{
    public class PessoaViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="O nome é obrigatório")]
        [MaxLength(75)]
        public string Nome { get; set; }
        [Required(ErrorMessage ="O Cpf é obrigatório")]
        [MaxLength(11)]
        [MinLength(11)]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "O Nis é obrigatório")]
        public string Nis { get; set; }
        [Display(Name ="Sexo")]
        public int SexoId { get; set; }
        public virtual SexoViewModel Sexo { get; set; }
        [Display(Name ="Nacionalidade")]
        public int NacionalidadeId { get; set; }
        public virtual NacionalidadeViewModel Nacionalidade { get; set; }
        [Display(Name ="Dt. Nascimento")]
        public DateTime DataNascimento { get; set; }
        [Display(Name ="Rg - Num.")]
        public string RgNum { get; set; }
        [Display(Name ="Rg - Orgão Emissor")]
        public string RgOrgaoEmissor { get; set; }
        [Display(Name = "Rg - Uf Orgão Emissor")]
        [MaxLength(2)]
        public string RgSiglaOrgaoEmissor { get; set; }
        [Display(Name = "Rg - Data de emissão.")]
        public string RgDataExpedicao { get; set; }
        [Display(Name = "Titulo de Eleitor - Num.")]
        public string TituloEleitor { get; set; }
        [Display(Name = "Titulo de Eleitor - Zona")]
        public string TituloEleitorZona { get; set; }
        [Display(Name = "Titulo de Eleitor - Seção")]
        public string TituloEleitorSecao { get; set; }
        [Display(Name = "Titulo de Eleitor - Municipio")]
        public string TituloEleitorMunicipio { get; set; }
        [Display(Name = "Titulo de Eleitor - Uf")]
        [MaxLength(2)]
        public string TituloEleitorUf { get; set; }
        public string Pis { get; set; }
        [Display(Name ="Estado Civil")]
        public int EstadoCivilId { get; set; }
        public virtual EstadoCivilViewModel EstadoCivil { get; set; }
        public string Profissao { get; set; }
        [Display(Name = "Situação da atividade atual")]
        public int AtividadeId { get; set; }
        public virtual AtividadeViewModel Atividade { get; set; }
        [Display(Name = "Tempo de trabalho na atividade atual - Anos")]
        public int TempoTrabalhoAtividadeAnos { get; set; }
        [Display(Name = "Tempo de trabalho na atividade atual - Meses")]
        public int TempoTrabalhoAtividadeMeses { get; set; }
        [Display(Name = "Local de trabalho atividade atual")]
        public string LocalOndeExerceAtividade { get; set; }
        [Display(Name = "Banco - Agência")]
        public string BancoAgencia { get; set; }
        [Display(Name = "Banco - Operação")]
        public string BancoOperacao { get; set; }
        [Display(Name = "Banco - Conta")]
        public string BancoConta { get; set; }
        [Display(Name = "Conta conjunta?")]
        public bool ContaConjuta { get; set; }
        [Display(Name = "Naturalidade")]
        public int NaturalidadeId { get; set; }
        public virtual NaturalidadeViewModel Naturalidade { get; set; }
        [Display(Name = "Menor emancipado?")]
        public bool MenorEmancipado { get; set; }
        [Display(Name ="Menor assistido")]
        public bool MenorAssistido { get; set; }
        [Display(Name = "Escolaridade")]
        public int GrauInstrucaoId { get; set; }
        public virtual GrauInstrucaoViewModel GrauInstrucao { get; set; }
        public string Cep { get; set; }
        [Display(Name = "Rua/Av.")]
        public string Logradouro { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        [MaxLength(2)]
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Situação da residência atual")]
        public int ResidenciaAtualId { get; set; }
        public virtual ResidenciaAtualViewModel ResidenciaAtual { get; set; }
        [Display(Name = "Valor da renda comprovada")]
        public decimal? RendaComprovada { get; set; }
        [Display(Name = "Valor da renda não comprovada")]
        public decimal? RendaNaoComprovada { get; set; }
        [Display(Name = "Ultimo emprego - Anos")]
        public int? UltimoEmpregoAnos { get; set; }
        [Display(Name = "Ultimo emprego - Meses")]
        public int? UltimoEmpregoMes { get; set; }
        [Display(Name = "Ultimo emprego - Ano do desligamento")]
        public int? UltimoEmpregoAnoDesligamento { get; set; }
        [Display(Name = "Ultimo emprego - Cargo/Função")]
        public string CargoFuncao { get; set; }
        [Display(Name = "Documentos complementar")]
        public int DocumentosComplementaresId { get; set; }
        public virtual DocumentosComplementaresViewModel DocumentosComplementares { get; set; }
        [Display(Name = "Possui imóvel?")]
        public bool PossuiImoveis { get; set; }
        [Display(Name = "Qual o tipo do imóvel")]
        public int TipoImovelId { get; set; }
        public virtual TipoImovelViewModel TipoImovel { get; set; }
        [Display(Name = "Possui veículo?")]
        public bool PossuiVeiculos { get; set; }
        [Display(Name = "Qual tipo de veículo")]
        public int TipoVeiculoId { get; set; }
        public virtual TipoVeiculoViewModel TipoVeiculo { get; set; }
        [Display(Name = "Tem Cartão de crédito?")]
        public bool CartaoCredito { get; set; }
        [Display(Name = "Tem conta em outro banco?")]
        public bool ContaOutrosBancos { get; set; }
        [Display(Name = "Tem aplicações fora da Caixa Econômica")]
        public int AplicacoesForaCaixaId { get; set; }
        public virtual AplicacoesForaCaixaViewModel AplicacoesForaCaixa { get; set; }
        [Display(Name = "Qtd. de dependentes")]
        public int? DependentesQtd { get; set; }
        [Display(Name = "Qtd. de dependentes sem renda")]
        public int? DependentesQtdSemRenda { get; set; }
        [Display(Name = "Total da renda liquida dos dependentes")]
        public decimal? DependentesTotalRendaLiquida { get; set; }
        [Display(Name = "Qtd. de pessoas idosas na moradia")]
        public int? PessoaIdosaQtd { get; set; }
        [Display(Name = "Qtd. de pessoas com deficiência na moradia")]
        public int? PessoaDeficienteQtd { get; set; }
        [Display(Name = "Total de pessoas na moradia")]
        public int PessoaMoradiaQtd { get; set; }
        [Display(Name = "Entidade")]
        public int EntidadeId { get; set; }
        public virtual EntidadeViewModel Entidade { get; set; }
        public virtual IEnumerable<DependenteViewModel> Dependentes { get; set; }
        public virtual IEnumerable<ConjugeViewModel> Conjuge { get; set; }
        [ScaffoldColumn(false)]
        public DateTime? DataCadastro { get; set; }
    }
}