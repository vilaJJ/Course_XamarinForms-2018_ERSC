namespace Mimica.Models
{
    public class Grupo
    {
        public int Id { get; set; }
        public ushort Pontuacao { get; set; } 
        public string Nome { get; set; }

        public string Titulo
        {
            get => string.Format(
                "Grupo {0}{1}",
                Id,
                string.IsNullOrWhiteSpace(Nome) ? string.Empty : $" - {Nome}"
                );
        }

        public Grupo(int id) 
        {
            Id = id;
        }

        public Grupo(int id, string nome) 
        {
            Id = id;
            Pontuacao = 0;
            Nome = nome;
        }

        public void AdicionarPontuacao(ushort pontos)
        {
            Pontuacao = pontos;
        }
    }
}
