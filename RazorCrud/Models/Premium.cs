using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorCrud.Models
{
    public class Premium
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        [StringLength(80, ErrorMessage = "O campo Título deve ter no máximo 80 caracteres.")]
        [MinLength(5, ErrorMessage = "O campo Título deve ter no mínimo 5 caracteres.")]
        [DisplayName("Título")]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        [DisplayName("Data de Início")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Data de Término")]
        public DateTime EndDate { get; set; }

        [DisplayName("Aluno")]
        [Required(ErrorMessage = "O campo Aluno é obrigatório.")]
        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
