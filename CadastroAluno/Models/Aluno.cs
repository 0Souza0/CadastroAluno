using System.ComponentModel.DataAnnotations;

namespace CadastroAluno.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nome deve ter entre 3 e 100 caracteres")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "E-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "RA é obrigatório")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "RA deve ter entre 6 e 10 caracteres")]
        [Display(Name = "RA (Registro Acadêmico)")]
        public string RA { get; set; }

        [Required(ErrorMessage = "Curso é obrigatório")]
        [StringLength(100, ErrorMessage = "Curso deve ter no máximo 100 caracteres")]
        [Display(Name = "Curso")]
        public string Curso { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é obrigatória")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
