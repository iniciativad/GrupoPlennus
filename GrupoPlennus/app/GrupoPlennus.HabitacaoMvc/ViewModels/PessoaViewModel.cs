using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace GrupoPlennus.HabitacaoMvc.ViewModels
{
    public class PessoaViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(75)]
        public string Nome { get; set; }
        [MaxLength(11)]
        [MinLength(11)]
        [Required(ErrorMessage = "O Cpf é obrigatório")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "O Nis é obrigatório")]
        public string Nis { get; set; }
        [Display(Name = "Sexo")]
        public int SexoId { get; set; }
        [Display(Name = "Nacionalidade")]
        public int NacionalidadeId { get; set; }
        [Display(Name = "Dt. Nascimento")]
        public DateTime DataNascimento { get; set; }
        [Display(Name = "Num. Rg")]
        public string RgNum { get; set; }
        [Display(Name = "Orgão Emissor")]
        public string RgOrgaoEmissor { get; set; }
        [Display(Name = "Uf do Orgão Emissor")]
        public string RgSiglaOrgaoEmissor { get; set; }
        [Display(Name = "Dt. de Emissão do Rg")]
        public string RgDataExpedicao { get; set; }
        [Display(Name = "Titulo de eleitor")]
        public string TituloEleitor { get; set; }
        [Display(Name = "Titulo - Zona")]
        public string TituloEleitorZona { get; set; }
        [Display(Name = "Titulo - Seção")]
        public string TituloEleitorSecao { get; set; }
        [Display(Name = "Titulo - Municipio/Cidade")]
        public string TituloEleitorMunicipio { get; set; }
        [Display(Name = "Titulo - Uf")]
        public string TituloEleitorUf { get; set; }
        [Display(Name = "Estado Civil")]
        public int EstadoCivilId { get; set; }
        public string Profissao { get; set; }
        [Display(Name = "Atividade")]
        public int AtividadeId { get; set; }
        [Display(Name = "Tempo de Trabalho na Atividade / Anos")]
        public int TempoTrabalhoAtividadeAnos { get; set; }
        [Display(Name = "Tempo de Trabalho na Atividade / Mes(es)")]
        public int TempoTrabalhoAtividadeMeses { get; set; }
        [Display(Name = "Local onde exerce a atividade")]
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
        [Display(Name = "É menor emancipado?")]
        public bool MenorEmancipado { get; set; }
        [Display(Name = "Menor assistido?")]
        public bool MenorAssistido { get; set; }
        [Display(Name = "Escolaridade")]
        public int GrauInstrucaoId { get; set; }
        public string Cep { get; set; }
        [Display(Name = "Rua/Av.")]
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public int? ResidenciaAtualId { get; set; }
        [Display(Name = "Renda comprovada")]
        public decimal? RendaComprovada { get; set; }
        [Display(Name = "Renda não comprovada")]
        public decimal? RendaNaoComprovada { get; set; }
        [Display(Name = "Qts anos ficou no ultimo emprego")]
        public int UltimoEmpregoAnos { get; set; }
        [Display(Name = "Qts meses no ultimo emprego")]
        public int UltimoEmpregoMes { get; set; }
        [Display(Name = "Ano do desligamento do ultimo emprego")]
        public int UltimoEmpregoAnoDesligamento { get; set; }
        [Display(Name = "Cargo/Função ultimo emprego")]
        public string CargoFuncao { get; set; }
        public int DocumentosComplementares { get; set; }
        public int? InformacoesPatrimoniaisId { get; set; }
        public bool PossuiImoveis { get; set; }
        public bool PossuiVeiculos { get; set; }
        public int? CartaoCreditoId { get; set; }
        public int? ContaOutrosBancosId { get; set; }
        public int? AplicacoesForaCaixaId { get; set; }
        [Display(Name = "Qtd de dependentes")]
        public int DependentesQtd { get; set; }
        [Display(Name = "Qtd de dependentes sem renda")]
        public int DependentesQtdSemRenda { get; set; }
        [Display(Name = "Total liquido da renda dos dependentes")]
        public decimal DependentesTotalRendaLiquida { get; set; }
        [Display(Name = "Qtd de pessoas idosas")]
        public int PessoaIdosaQtd { get; set; }
        [Display(Name = "Qtd de pessoas com deficiência")]
        public int PessoaDeficienteQtd { get; set; }
        [Display(Name = "Total de pessoas na moradia")]
        public int PessoaMoradiaQtd { get; set; }
        [Display(Name = "Entidade")]
        public int EntidadeId { get; set; }
        public virtual EntidadeViewModel Entidade { get; set; }
        public virtual IEnumerable<DependenteViewModel> Dependentes { get; set; }
        public virtual IEnumerable<ConjugeViewModel> Conjuge { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}