
using System;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Entities
{
    public class Pessoa
    {
        public int Id { get; set; }        
        public string Nome { get; set; }     
        public string Cpf { get; set; }
        public string Nis { get; set; }      
        public int SexoId { get; set; }
        public virtual Sexo Sexo { get; set; }
        public int NacionalidadeId { get; set; }
        public virtual Nacionalidade Nacionalidade { get; set; }
        public DateTime DataNascimento { get; set; }      
        public string RgNum { get; set; }       
        public string RgOrgaoEmissor { get; set; }      
        public string RgSiglaOrgaoEmissor { get; set; }        
        public string RgDataExpedicao { get; set; }
        public string TituloEleitor { get; set; }
        public string TituloEleitorZona { get; set; }
        public string TituloEleitorSecao { get; set; }
        public string TituloEleitorMunicipio { get; set; }
        public string TituloEleitorUf { get; set; }
        public string Pis { get; set; }      
        public int EstadoCivilId { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public string Profissao { get; set; }    
        public int AtividadeId { get; set; }
        public virtual Atividade Atividade { get; set; }
        public int? TempoTrabalhoAtividadeAnos { get; set; }       
        public int? TempoTrabalhoAtividadeMeses { get; set; }       
        public string LocalOndeExerceAtividade { get; set; }       
        public string BancoAgencia { get; set; }      
        public string BancoOperacao { get; set; }       
        public string BancoConta { get; set; }       
        public bool ContaConjuta { get; set; }        
        public int NaturalidadeId { get; set; }
        public virtual Naturalidade Naturalidade { get; set; }
        public bool MenorEmancipado { get; set; }        
        public bool MenorAssistido { get; set; }
        public int GrauInstrucaoId { get; set; }
        public virtual GrauInstrucao GrauInstrucao { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public int ResidenciaAtualId { get; set; }
        public virtual ResidenciaAtual ResidenciaAtual { get; set; }
            
        public int? UltimoEmpregoAnos { get; set; }       
        public int? UltimoEmpregoMes { get; set; }      
        public int? UltimoEmpregoAnoDesligamento { get; set; }       
        public string CargoFuncao { get; set; }        
        public int DocumentosComplementaresId { get; set; }
        public virtual DocumentosComplementares DocumentosComplementares { get; set; }
       
        public int TipoImovelId { get; set; }
        public virtual TipoImovel TipoImovel { get; set; }
       
        public int TipoVeiculoId { get; set; }
        public virtual TipoVeiculo TipoVeiculo { get; set; }
        public bool CartaoCredito { get; set; }      
        public bool ContaOutrosBancos { get; set; }       
        public int AplicacoesForaCaixaId { get; set; }
        public virtual AplicacoesForaCaixa AplicacoesForaCaixa { get; set; }
        public int? DependentesQtd { get; set; }     
        public int? DependentesQtdSemRenda { get; set; }      
        public decimal? DependentesTotalRendaLiquida { get; set; }
        public int? PessoaIdosaQtd { get; set; }
        public int? PessoaDeficienteQtd { get; set; }
        public int PessoaMoradiaQtd { get; set; }
        public int EntidadeId { get; set; }
        public virtual Entidade Entidade { get; set; }
        public virtual IEnumerable<Dependente> Dependentes { get; set; }
        public virtual IEnumerable<Conjuge> Conjuge { get; set; }
        public DateTime? DataCadastro { get; set; }

        public int FaixaSalarialId { get; set; }
        public virtual FaixaSalarial FaixaSalarial { get; set; }
        public int RendaId { get; set; }
        public virtual Renda Renda { get; set; }

    }
}
