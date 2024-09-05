using Mimica.Models.Enums;
using Xamarin.Forms;

namespace Mimica.Models
{
    public class Jogo
    {
        public Grupo GrupoAtual { get; private set; }

        public Grupo Grupo1 { get; set; }
        public Grupo Grupo2 { get; set; }

        public Dificuldade Dificuldade { get; set; }
        public short TempoPalavra { get; set; }
        public ushort Rodadas { get; set; }

        public int IndiceDificuldade
        {
            get => (int)Dificuldade;
            set => Dificuldade = (Dificuldade)value;
        }

        public Jogo() 
        {
            Grupo1 = new Grupo();
            Grupo2 = new Grupo();

            GrupoAtual = Grupo1;
        }

        public Jogo(Grupo grupo1, Grupo grupo2, Dificuldade dificuldade, short tempoPalavra, ushort rodadas)
        {
            Grupo1 = grupo1;
            Grupo2 = grupo2;
            Dificuldade = dificuldade;
            TempoPalavra = tempoPalavra;
            Rodadas = rodadas;
        }

        #region Métodos internos

        internal void TrocarGrupo()
        {
            bool isGrupo1Atual = GrupoAtual.Equals(Grupo1);
            GrupoAtual = isGrupo1Atual is true ? Grupo2 : Grupo1;

            if (isGrupo1Atual is false)
            {
                AvancarRodada();
            }
        }

        #endregion

        #region Métodos privados

        private void AvancarRodada()
        {
            Data.Armazenamento.RodadaAtual++;
            ValidarSeRodadasTerminaram();
        }

        private void ValidarSeRodadasTerminaram()
        {
            bool isFimDeJogo = Data.Armazenamento.RodadaAtual > Rodadas;

            if (isFimDeJogo is true)
            {
                Application.Current.MainPage = new Views.Resultado();
            }

            Data.Armazenamento.IsFimDeJogo = isFimDeJogo;
        }

        #endregion
    }
}
