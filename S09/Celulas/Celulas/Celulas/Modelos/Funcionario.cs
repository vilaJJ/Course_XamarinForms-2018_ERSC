namespace Celulas.Modelos
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Foto { get; set; }

        public Funcionario(string nome, string cargo) 
        {
            Nome = nome;
            Cargo = cargo;
            Foto = "jihyo.png";
        }
    }
}
