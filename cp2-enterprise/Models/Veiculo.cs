using cp2_enterprise.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace cp2_enterprise.Models
{
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Modelo { get; set; }

        [Required]
        public string? Placa { get; set; }

        [Required]
        public int Ano { get; set; }

        [Required]
        public CategoriaEnum Categoria { get; set; }
    }
}
