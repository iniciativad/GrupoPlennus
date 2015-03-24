using System;


namespace GrupoPlennus.Domain.Entities
{
    public class Dependente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Nis { get; set; }
        public int SexoId { get; set; }
        public int NacionalidadeId { get; set; }
        public DateTime DataNascimento { get; set; }
        public string RgNum { get; set; }
        public string RgOrgaoEmissor { get; set; }
        public string RgSiglaOrgaoEmissor { get; set; }
        public string RgDataExpedicao { get; set; }
        public string Pis { get; set; }
        public string TituloEleitor { get; set; }
        public string TituloEleitorZona { get; set; }
        public string TituloEleitorSecao { get; set; }
        public string TituloEleitorMunicipio { get; set; }
        public string TituloEleitorUf { get; set; }
        public int EstadoCivilId { get; set; }
        public string Profissao { get; set; }
        public int AtividadeId { get; set; }
        public int TempoTrabalhoAtividadeAnos { get; set; }
        public int TempoTrabalhoAtividadeMeses { get; set; }
        public string LocalOndeExerceAtividade { get; set; }
        public string BancoAgencia { get; set; }
        public string BancoOperacao { get; set; }
        public string BancoConta { get; set; }
        public bool ContaConjuta { get; set; }
        public int NaturalidadeId { get; set; }
        public bool MenorEmancipado { get; set; }
        public bool MenorAssistido { get; set; }
        public int GrauInstrucaoId { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public int ResidenciaAtualId { get; set; }
        public int RendaComprovadaId { get; set; }
        public int RendaNaoComprovadaId { get; set; }
        public int UltimoEmpregoAnos { get; set; }
        public int UltimoEmpregoMes { get; set; }
        public int UltimoEmpregoAnoDesligamento { get; set; }
        public string CargoFuncao { get; set; }
        public int DocumentosComplementares { get; set; }
        public int InformacoesPatrimoniaisId { get; set; }
        public bool PossuiImoveis { get; set; }
        public bool PossuiVeiculos { get; set; }
        public int CartaoCreditoId { get; set; }
        public int ContaOutrosBancosId { get; set; }
        public int AplicacoesForaCaixaId { get; set; }
        public int EntidadeId { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
