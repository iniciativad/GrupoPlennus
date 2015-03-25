using System.ComponentModel.DataAnnotations;

namespace GrupoPlennus.HabitacaoMvc.ViewModels
{
    public class EntidadeTiposViewModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
    }
}