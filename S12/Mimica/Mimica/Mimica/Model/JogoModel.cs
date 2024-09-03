using Mimica.Model.Enums;

namespace Mimica.Model
{
    public class JogoModel
    {
        public GrupoModel Grupo1 { get; private set; }
        public GrupoModel Grupo2 { get; private set; }

        public Dificuldade Dificuldade { get; private set; }
        public ushort TempoPalavra { get; private set; }
        public ushort Rodadas { get; private set; }

        public JogoModel(GrupoModel grupo1, GrupoModel grupo2, Dificuldade dificuldade, ushort tempoPalavra, ushort rodadas)
        {
            Grupo1 = grupo1;
            Grupo2 = grupo2;
            Dificuldade = dificuldade;
            TempoPalavra = tempoPalavra;
            Rodadas = rodadas;
        }
    }
}
