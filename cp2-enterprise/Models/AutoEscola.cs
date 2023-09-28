using System.ComponentModel.DataAnnotations;

namespace cp2_enterprise.Models
{
    public class AutoEscola
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? CEP { get; set; }

        [Required]
        public string? Logradouro { get; set; }

        [Required]
        public string? Numero { get; set; }

        [Required]
        public string? Bairro { get; set; }

        [Required]
        public string? Cidade { get; set; }

        [Required]
        public string? Estado { get; set; }

    }
}
