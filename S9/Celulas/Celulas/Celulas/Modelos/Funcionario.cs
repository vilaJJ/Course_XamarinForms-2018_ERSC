namespace Celulas.Modelos
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }

        public Funcionario(string nome, string cargo) 
        {
            Nome = nome;
            Cargo = cargo;
        }
    }
}
