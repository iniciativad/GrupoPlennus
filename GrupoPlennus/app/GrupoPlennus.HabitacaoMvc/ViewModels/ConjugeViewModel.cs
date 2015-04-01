using System;
using System.ComponentModel.DataAnnotations;

namespace GrupoPlennus.HabitacaoMvc.ViewModels
{
    public class ConjugeViewModel
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
        public virtual SexoViewModel Sexo { get; set; }
        [Display(Name = "Nacionalidade")]
        public int NacionalidadeId { get; set; }
        public virtual NacionalidadeViewModel Nacionalidade { get; set; }
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
        public virtual EstadoCivilViewModel EstadoCivil { get; set; }
        public string Profissao { get; set; }
        [Display(Name = "Atividade")]
        public int AtividadeId { get; set; }
        public virtual AtividadeViewModel Atividade { get; set; }
        [Display(Name = "Tempo de Trabalho na Atividade / Anos")]
        public int? TempoTrabalhoAtividadeAnos { get; set; }
        [Display(Name = "Tempo de Trabalho na Atividade / Mes(es)")]
        public int? TempoTrabalhoAtividadeMeses { get; set; }
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
        public virtual NaturalidadeViewModel Naturalidade { get; set; }
        [Display(Name = "É menor emancipado?")]
        public bool MenorEmancipado { get; set; }
        [Display(Name = "Menor assistido?")]
        public bool MenorAssistido { get; set; }
        [Display(Name = "Escolaridade")]
        public int GrauInstrucaoId { get; set; }
        public virtual GrauInstrucaoViewModel GrauInstrucao { get; set; }
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
       
        [Display(Name = "Qts anos ficou no ultimo emprego")]
        public int? UltimoEmpregoAnos { get; set; }
        [Display(Name = "Qts meses no ultimo emprego")]
        public int? UltimoEmpregoMes { get; set; }
        [Display(Name = "Ano do desligamento do ultimo emprego")]
        public int? UltimoEmpregoAnoDesligamento { get; set; }
        [Display(Name = "Cargo/Função ultimo emprego")]
        public string CargoFuncao { get; set; }
        
       
      
       
        public int PessoaId { get; set; }
        public virtual PessoaViewModel Pessoa { get; set; }
        public DateTime DataCadastro { get; set; }

        public int FaixaSalarialId { get; set; }
        public virtual FaixaSalarialViewModel FaixaSalarial { get; set; }
        public int RendaId { get; set; }
        public virtual RendaViewModel Renda { get; set; }
    }
}