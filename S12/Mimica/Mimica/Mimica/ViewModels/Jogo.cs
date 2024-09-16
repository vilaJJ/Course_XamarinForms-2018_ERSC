using Mimica.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Mimica.ViewModels
{
    internal class Jogo : INotifyPropertyChanged
    {
        #region Eventos

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Campos

        private ushort palavraPontuacao;

        private string palavra;
        private string contagemRegressiva;

        private bool exibirContagem;
        private bool exibirBotaoIniciar;
        private bool exibirBotaoMostrar;

        #endregion

        #region Propriedades

        public Models.Jogo JogoAtual
        {
            get => Data.Armazenamento.Jogo;
        }

        public ushort PalavraPontuacao
        {
            get => palavraPontuacao;
            set
            {
                palavraPontuacao = value;
                OnPropertyChanged(nameof(PalavraPontuacao));
            }
        }

        public string Palavra
        {
            get => palavra;
            set
            {
                palavra = value;
                OnPropertyChanged(nameof(Palavra));
            }
        }
        public string ContagemRegressiva
        {
            get => contagemRegressiva;
            set
            {
                contagemRegressiva = value;
                OnPropertyChanged(nameof(ContagemRegressiva));
            }
        }

        public bool ExibirContagem
        {
            get => exibirContagem;
            set
            {
                exibirContagem = value;
                OnPropertyChanged(nameof(ExibirContagem));
            }
        }
        public bool ExibirBotaoIniciar
        {
            get => exibirBotaoIniciar;
            set
            {
                exibirBotaoIniciar = value;
                OnPropertyChanged(nameof(ExibirBotaoIniciar));
            }
        }
        public bool ExibirBotaoMostrar
        {
            get => exibirBotaoMostrar;
            set
            {
                exibirBotaoMostrar = value;
                OnPropertyChanged(nameof(ExibirBotaoMostrar));
            }
        }

        public Command IniciarJogo { get; set; }
        public Command MostrarPalavra { get; set; }
        public Command AcertouPalavra { get; set; }
        public Command ErrouPalavra { get; set; }

        #endregion

        #region Construtores

        internal Jogo()
        {
            ExibirContagem = 
            ExibirBotaoIniciar =      
            false;

            ExibirBotaoMostrar = true;

            PalavraPontuacao = 0;
            Palavra = "**********";

            IniciarJogo = new Command(IniciarJogoCommand);
            MostrarPalavra = new Command(MostrarPalavraCommand);
            AcertouPalavra = new Command(AcertouPalavraCommand);
            ErrouPalavra = new Command(ErrouPalavraCommand);
        }

        #endregion
        
        #region Commands

        private void IniciarJogoCommand()
        {
            ExibirBotaoIniciar = false;
            ExibirContagem = true;

            IniciarContagemRegressiva();
        }

        private void MostrarPalavraCommand()
        {
            SortearPalavra();

            ExibirBotaoMostrar = false;
            ExibirBotaoIniciar = true;
        }

        private void AcertouPalavraCommand()
        {
            Data.Armazenamento.Jogo.GrupoAtual.Pontuacao += PalavraPontuacao;
            OnActionUsuarioResponsePalavra();
        }

        private void ErrouPalavraCommand()
        {
            OnActionUsuarioResponsePalavra();
        }

        #endregion

        #region Métodos Privados

        private void SortearPalavra()
        {
            List<string> palavras = new List<string>();
            
            Random randomSelector = new Random();
            Dificuldade dificuldade = Data.Armazenamento.Jogo.Dificuldade;

            if (dificuldade is Dificuldade.Aleatorio)
            {
                int indiceDificuldadeSorteado = randomSelector.Next(1, 4);
                dificuldade = (Dificuldade)indiceDificuldadeSorteado;
            }

            Data.Armazenamento.Palavras.Where(palavra => palavra.Key == dificuldade).ForEach((value) =>
            {
                palavras = value.Value;
            });

            int valorMaximo = palavras.Count;
            int indiceAleatorio = randomSelector.Next(0, valorMaximo - 1);

            string palavraSorteada = palavras[indiceAleatorio];
            ushort pontuacao = dificuldade.ObterPontuacao();
            
            Palavra = palavraSorteada;
            PalavraPontuacao = pontuacao;
        }

        private void OnActionUsuarioResponsePalavra()
        {
            PalavraPontuacao = 0;
            Data.Armazenamento.Jogo.TrocarGrupo();

            if (Data.Armazenamento.IsFimDeJogo is false)
            {
                Application.Current.MainPage = new Views.Jogo();
            }
        }

        private void IniciarContagemRegressiva()
        {
            short tempo = Data.Armazenamento.Jogo.TempoPalavra;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                tempo--;

                bool isTempoEsgotado = tempo < 0;
                ContagemRegressiva = isTempoEsgotado is true ? "Esgotou o tempo" : tempo.ToString();

                return isTempoEsgotado is false;
            });
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
