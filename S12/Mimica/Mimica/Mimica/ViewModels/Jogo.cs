using Xamarin.Forms;

namespace Mimica.ViewModels
{
    internal class Jogo
    {
        #region Propriedades

        public short PalavraPontuacao { get; set; }

        public string Palavra { get; set; }
        public string ContagemRegressiva { get; set; }

        public bool ExibirContagem { get; set; }
        public bool ExibirBotaoIniciar { get; set; }

        public Command IniciarJogo { get; set; }
        public Command MostrarPalavra { get; set; }
        public Command AcertouPalavra { get; set; }
        public Command ErrouPalavra { get; set; }

        #endregion

        #region Construtores

        internal Jogo()
        {
            ExibirContagem = false;
            ExibirBotaoIniciar = false;

            IniciarJogo = new Command(() => { });
            MostrarPalavra = new Command(() => { });
            AcertouPalavra = new Command(() => { });
            ErrouPalavra = new Command(() => { });
        }

        #endregion
    }
}
