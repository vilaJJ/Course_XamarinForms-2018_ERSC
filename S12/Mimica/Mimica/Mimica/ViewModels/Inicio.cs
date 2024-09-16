using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Mimica.ViewModels
{
    public class Inicio : INotifyPropertyChanged
    {
        #region Eventos

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Propriedades privadas

        private string mensagemErro;
        private bool isVisibleMensagemErro;

        #endregion

        #region Propriedades públicas

        public Models.Jogo Jogo { get; set; }
        public Command IniciarCommand { get; set; }
        public string MensagemErro { 
            get => mensagemErro;
            set 
            {
                mensagemErro = value;
                IsVisibleMensagemErro = string.IsNullOrWhiteSpace(value) is false;

                OnPropertyChanged(nameof(MensagemErro));
            }            
        }
        public bool IsVisibleMensagemErro
        {
            get => isVisibleMensagemErro;
            set
            {
                isVisibleMensagemErro = value;
                OnPropertyChanged(nameof(IsVisibleMensagemErro));
            }
        }

        #endregion

        #region Construtores

        public Inicio()
        {
            Jogo = new Models.Jogo();
            IniciarCommand = new Command(IniciarJogo);

            Jogo.TempoPalavra = 60;
            Jogo.Rodadas = 5;
        }

        #endregion

        #region Métodos Privados

        private void IniciarJogo()
        {
            bool isDadosValidos = ValidarDadosInformados();

            if (isDadosValidos is false)
            {
                return;
            }

            Data.Armazenamento.Jogo = Jogo;
            Data.Armazenamento.RodadaAtual = 1;

            Application.Current.MainPage = new Views.Jogo();
        }

        private bool ValidarDadosInformados()
        {
            string mensagemErro = string.Empty;

            if (Jogo.TempoPalavra < 10)
            {
                mensagemErro += "O tempo mínimo para o tempo da palavra é de 10 segundos.\n";
            }
            if (Jogo.Rodadas < 1)
            {
                mensagemErro += "É necessário ter pelo menos uma rodada.\n";
            }

            MensagemErro = mensagemErro;
            return IsVisibleMensagemErro is false;
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
