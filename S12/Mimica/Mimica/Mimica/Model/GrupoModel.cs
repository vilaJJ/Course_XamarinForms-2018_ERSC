namespace Mimica.Model
{
    public class GrupoModel
    {
        public ushort Pontuacao { get; private set; } 
        public string Nome { get; private set; }

        public GrupoModel(string nome) 
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
