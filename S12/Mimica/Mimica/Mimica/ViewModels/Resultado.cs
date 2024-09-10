using System.ComponentModel;
using Xamarin.Forms;

namespace Mimica.ViewModels
{
    internal class Resultado : INotifyPropertyChanged
    {
        #region Eventos

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Propriedades

        public Models.Jogo JogoAtual
        {
            get => Data.Armazenamento.Jogo;
        }

        public Command JogarNovamente { get; set; }

        #endregion

        #region Construtores

        public Resultado()
        {
            JogarNovamente = new Command(JogarNovamenteCommand);
        }

        #endregion

        #region Commands

        private void JogarNovamenteCommand()
        {
            Application.Current.MainPage = new Views.Inicio();
        }

        #endregion

        #region Métodos Privados

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
