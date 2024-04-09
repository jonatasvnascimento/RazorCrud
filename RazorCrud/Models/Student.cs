using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorCrud.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(80, ErrorMessage = "O campo Nome deve ter no máximo 80 caracteres.")]
        [MinLength(5, ErrorMessage = "O campo Nome deve ter no mínimo 5 caracteres.")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; } = String.Empty;

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo Email deve ser um endereço de email válido.")]
        [DisplayName("E-mail")]
        public string Email { get; set; } = String.Empty;

        public List<Premium> Premiums { get; set; } = new();


    }
}
