using System;
using System.Collections.Generic;

namespace GrupoPlennus.Domain.Entities
{
    public class EntidadeMaster
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
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
        public string Email { get; set; }
        public string Responsavel { get; set; }
        public string ResponsavelCpf { get; set; }
        public string ResponsavelCargo { get; set; }
        public string TipoEntidade { get; set; }
        public DateTime DataFundacao { get; set; }
        public string OutrasExperienciasHabitacao { get; set; }
        public string FiliacaoMovimentoNacional { get; set; }
        public string Banco { get; set; }
        public string BancoAgencia { get; set; }
        public string BancoConta { get; set; }
        public string BancoOperacao { get; set; }

        public virtual IEnumerable<Entidade> Entidades { get; set; }
    }
}