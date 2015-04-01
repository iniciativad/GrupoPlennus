using System;


namespace GrupoPlennus.Domain.Entities
{
    public class Dependente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int SexoId { get; set; }
        public virtual Sexo Sexo { get; set; }
        public string Cpf { get; set; }
        public string Nis { get; set; }                 
        public int GrauInstrucaoId { get; set; }
        public virtual GrauInstrucao GrauInstrucao { get; set; }
        public decimal? RendaComprovada { get; set; }
        public decimal? RendaNaoComprovada { get; set; }
        public bool Deficiente { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public DateTime? DataCadastro { get; set; }
    }
}
