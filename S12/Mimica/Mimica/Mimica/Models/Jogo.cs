using Mimica.Models.Enums;

namespace Mimica.Models
{
    public class Jogo
    {
        public Grupo Grupo1 { get; private set; }
        public Grupo Grupo2 { get; private set; }

        public Dificuldade Dificuldade { get; private set; }
        public ushort TempoPalavra { get; private set; }
        public ushort Rodadas { get; private set; }

        public int IndiceDificuldade
        {
            get => (int)Dificuldade;
            set => Dificuldade = (Dificuldade)value;
        }

        public Jogo(Grupo grupo1, Grupo grupo2, Dificuldade dificuldade, ushort tempoPalavra, ushort rodadas)
        {
            Grupo1 = grupo1;
            Grupo2 = grupo2;
            Dificuldade = dificuldade;
            TempoPalavra = tempoPalavra;
            Rodadas = rodadas;
        }
    }
}
