using System;
using Vagas.Database;
using Vagas.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaVagas : ContentPage
    {
        public ConsultaVagas()
        {
            InitializeComponent();

            CarregarVagas();
        }

        protected override void OnAppearing()
        {
            CarregarVagas();
            base.OnAppearing();
        }

        private void Button_AdicionarVaga_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroVaga());
        }

        private void Button_MinhasVagas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VagasCadastradas());
        }

        private void TapGestureRecognizer_MaisDetalhes_Tapped(object sender, EventArgs e)
        {
            var labelDetalhe = sender as Label;
            var labelDetalheGesture = labelDetalhe.GestureRecognizers[0] as TapGestureRecognizer;

            var vaga = labelDetalheGesture.CommandParameter as Vaga;

            Navigation.PushAsync(new DetalheVaga(vaga));
        }

        private void CarregarVagas()
        {
            string campoPesquisa = null;
            var entryPesquisa = Entry_Pesquisa?.Text?.Trim();

            if (string.IsNullOrEmpty(entryPesquisa) is false)
            {
                campoPesquisa = entryPesquisa;
            }

            using (var databaseHelper = new DatabaseHelper())
            {
                var lista = databaseHelper.Obter(campoPesquisa);
                ListView_Vagas.ItemsSource = lista;

                PreencherLabelQntd(lista.Count);
            }
        }

        private void PreencherLabelQntd(int quantidade)
        {
            string texto;

            if (quantidade is 0)
            {
                texto = "Nenhuma vaga encontrada";
            }
            else if (quantidade is 1)
            {
                texto = "Uma vaga encontrada";
            }
            else
            {
                texto = string.Format("{0} vagas encontradas", quantidade);
            }

            Label_QntdVagasEncontradas.Text = texto;
        }

        private void Entry_Pesquisa_TextChanged(object sender, TextChangedEventArgs e)
        {
            CarregarVagas();
        }
    }
}