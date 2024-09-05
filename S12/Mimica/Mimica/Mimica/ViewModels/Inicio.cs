using System.ComponentModel;
using Xamarin.Forms;

namespace Mimica.ViewModels
{
    public class Inicio : INotifyPropertyChanged
    {
        #region Eventos

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Propriedades

        public Models.Jogo Jogo { get; set; }
        public Command IniciarCommand { get; set; }

        #endregion

        #region Construtores

        public Inicio()
        {
            Jogo = new Models.Jogo();
            IniciarCommand = new Command(IniciarJogo);
        }

        #endregion

        #region Métodos Privados

        private void IniciarJogo()
        {
            Data.Armazenamento.Jogo = Jogo;
            Data.Armazenamento.RodadaAtual = 1;

            Application.Current.MainPage = new Views.Jogo();
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged is null)
            {
                return;
            }

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
