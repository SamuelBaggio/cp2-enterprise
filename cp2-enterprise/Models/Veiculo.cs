using cp2_enterprise.Models.Enum;

namespace cp2_enterprise.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        public string Modelo { get; set; }

        public string Placa { get; set; }

        public int Ano { get; set; }

        public CategoriaEnum Categoria { get; set; }
    }
}
