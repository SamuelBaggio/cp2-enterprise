using cp2_enterprise.Models.Enum;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace cp2_enterprise.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string? Sexo { get; set; }

        [Required]
        public string? Cpf { get; set; }

        [Required]
        public string? Renach { get; set; }

        [Required]
        public string? Categoria { get; set; }

    }
}
