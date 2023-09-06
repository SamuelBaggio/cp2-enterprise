namespace cp2_enterprise.Models
{
    public class AutoEscola
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        // relacionamento com Aluno
        // relacionamento com Funcionario
        // relacionamento com Veiculo

        public string? CEP { get; set; }
        public string? Logradouro { get; set; } 
        public string? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }


    }
}
