using System;
using System.ComponentModel.DataAnnotations;

namespace GrupoPlennus.HabitacaoMvc.ViewModels
{
    public class DependenteViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name ="Dt. Nascimento")]
        public DateTime DataNascimento { get; set; }
        [Display(Name ="Sexo")]
        public int SexoId { get; set; }
        public virtual SexoViewModel Sexo { get; set; }
        public string Cpf { get; set; }
        public string Nis { get; set; }
        [Display(Name ="Escolaridade")]
        public int GrauInstrucaoId { get; set; }
        public virtual GrauInstrucaoViewModel GrauInstrucao { get; set; }
        [Display(Name ="Renda comprovada")]
        public decimal? RendaComprovada { get; set; }
        [Display(Name ="Renda não comprovada")]
        public decimal? RendaNaoComprovada { get; set; }
        [Display(Name ="Deficiente?")]
        public bool Deficiente { get; set; }
        [ScaffoldColumn(false)]
        public int PessoaId { get; set; }
        public virtual PessoaViewModel Pessoa { get; set; }
        [ScaffoldColumn(false)]
        public DateTime? DataCadastro { get; set; }
    }
}