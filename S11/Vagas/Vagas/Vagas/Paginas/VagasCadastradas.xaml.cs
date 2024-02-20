using System;
using Vagas.Database;
using Vagas.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VagasCadastradas : ContentPage
    {
        public VagasCadastradas()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            CarregarVagas();
            base.OnAppearing();
        }

        private void TapGestureRecognizer_Editar_Tapped(object sender, EventArgs e)
        {
            var labelDetalhe = sender as Label;
            var labelDetalheGesture = labelDetalhe.GestureRecognizers[0] as TapGestureRecognizer;

            var vaga = labelDetalheGesture.CommandParameter as Vaga;

            Navigation.PushAsync(new EditarVaga(vaga));
        }

        private void TapGestureRecognizer_Excluir_Tapped(object sender, EventArgs e)
        {
            var labelDetalhe = sender as Label;
            var labelDetalheGesture = labelDetalhe.GestureRecognizers[0] as TapGestureRecognizer;

            var vaga = labelDetalheGesture.CommandParameter as Vaga;

            ExcluirVaga(vaga.Id);

            DisplayAlert(
                "Apagar Vaga",
                "Vaga apagada com sucesso!",
                "OK"
                );

            CarregarVagas();
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

        private void ExcluirVaga(int codigoVaga)
        {
            using (var databaseHelper = new DatabaseHelper())
            {
                databaseHelper.Excluir(codigoVaga);
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