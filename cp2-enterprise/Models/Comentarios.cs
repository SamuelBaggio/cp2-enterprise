using System.ComponentModel.DataAnnotations;

namespace cp2_enterprise.Models
{
    public class Comentarios
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? Texto { get; set; }

        [Required]
        [Range(0, 5)]
        public int? Estrelas { get; set; }

        [Required]
        public bool AutorizaNome { get; set; }

    }
}
