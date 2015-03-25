using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GrupoPlennus.HabitacaoMvc.ViewModels
{
    public class EntidadeViewModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }
        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }
        
        public string Cnpj { get; set; }

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }

        public string Telefone { get; set; }
        

        [Display(Name = "E-mail")]
        public string Email { get; set; }
        public string Responsavel { get; set; }
        [Display(Name = "Cpf do responsável")]
        public string ResponsavelCpf { get; set; }
        [Display(Name = "Cargo/Função do responsável")]
        public string ResponsavelCargo { get; set; }
        [Display(Name ="Tipo de entidade")]
        public int EntidadeTiposId { get; set; }
        public virtual EntidadeTiposViewModel EntidadeTipos { get; set; }
        [Display(Name ="Data da fundação")]
        public DateTime DataFundacao { get; set; }
        [Display(Name ="Outras Experiêncis com habitação")]
        public string OutrasExperienciasHabitacao { get; set; }
        [Display(Name ="É filiado há movimento nacional, Qual?")]
        public string FiliacaoMovimentoNacional { get; set; }
        public string Banco { get; set; }
        [Display(Name = "Banco - Agência")]
        public string BancoAgencia { get; set; }
        [Display(Name = "Banco - Conta")]
        public string BancoConta { get; set; }
        [Display(Name = "Banco - Operação")]
        public string BancoOperacao { get; set; }
        [Display(Name ="Entidade-Vinculo")]
        public int EntidadeMasterId { get; set; }
        public virtual EntidadeMasterViewModel EntiadeMaster { get; set; }
        public virtual IEnumerable<PessoaViewModel> Pessoas { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}