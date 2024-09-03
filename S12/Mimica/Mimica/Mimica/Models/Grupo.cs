namespace Mimica.Models
{
    public class Grupo
    {
        public ushort Pontuacao { get; private set; } 
        public string Nome { get; private set; }

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
