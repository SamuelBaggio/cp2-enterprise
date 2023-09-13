using System.ComponentModel.DataAnnotations;

namespace cp2_enterprise.Models
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? Cpf { get; set; }

        [Required]
        public string? Cargo { get; set; }
    }
}
