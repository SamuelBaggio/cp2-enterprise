using cp2_enterprise.Models.Enum;

namespace cp2_enterprise.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public SexoEnum Sexo { get; set; }
        public string? Cpf { get; set; }
        public string? Renach { get; set; }
        public CategoriaEnum Categoria { get; set; }

    }
}
