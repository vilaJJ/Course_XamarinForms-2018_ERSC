using SQLite;

namespace Vagas.Models
{
    [Table("Vagas")]
    public class Vaga
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string Empresa { get; set; }
        public string Cidade { get; set; }
        public float Salario { get; set; }
        public string DescricaoCargo { get; set; }
        public string TipoContratacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
