namespace Mimica.Models
{
    public class Grupo
    {
        public ushort Pontuacao { get; set; } 
        public string Nome { get; set; }

        public Grupo() { }

        public Grupo(string nome) 
        {
            Pontuacao = 0;
            Nome = nome;
        }

        public void AdicionarPontuacao(ushort pontos)
        {
            Pontuacao = pontos;
        }
    }
}
