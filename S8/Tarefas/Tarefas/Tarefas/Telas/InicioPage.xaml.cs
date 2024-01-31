using System;
using System.Collections.Generic;
using Tarefas.Data;
using Tarefas.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarefas.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioPage : ContentPage
    {
        public InicioPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            AtualizarListaTarefas();
        }

        private void Button_AdicionarTarefa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroPage());
        }

        private void AtualizarListaTarefas()
        {
            StackLayout_Tarefas.Children.Clear();

            var tarefas = GerenciadorTarefas.Obter();
            ListarTarefas(tarefas);
        }

        private void ListarTarefas(List<Tarefa> tarefas)
        {
            foreach (var tarefa in tarefas)
            {
                var stackLayout = tarefa.Finalizada
                    ? ObterTarefaFechada(tarefa)
                    : ObterTarefaAberta(tarefa);

                StackLayout_Tarefas.Children.Add(stackLayout);
            }
        }

        private StackLayout ObterTarefaAberta(Tarefa tarefa)
        {
            var imagemCheck = ObterImagemCheck(tarefa.Finalizada);

            var imagemPrioridade = ObterImagemPrioridade(tarefa.ObterNomeImagemPrioridade());

            var imagemExcluir = ObterImagemExcluir(tarefa.ObterNomeImagemExcluir());

            var labelTitulo = new Label()
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = tarefa.Nome,
                TextColor = Color.Black
            };

            var stackLayout = new StackLayout()
            {
                Spacing = 15,
                Orientation = StackOrientation.Horizontal
            };

            stackLayout.Children.Add(imagemCheck);
            stackLayout.Children.Add(labelTitulo);
            stackLayout.Children.Add(imagemPrioridade);
            stackLayout.Children.Add(imagemExcluir);

            return stackLayout;
        }

        private StackLayout ObterTarefaFechada(Tarefa tarefa)
        {
            var imagemCheck = ObterImagemCheck(tarefa.Finalizada);

            var stackLayoutTitulo = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Spacing = 0
            };

            var imagemPrioridade = ObterImagemPrioridade(tarefa.ObterNomeImagemPrioridade());

            var imagemExcluir = ObterImagemExcluir(tarefa.ObterNomeImagemExcluir());

            var labelTitulo = new Label()
            {
                Text = tarefa.Nome,
                TextColor = Color.Gray
            };

            var labelFinalizado = new Label()
            {
                Text = tarefa.ObterFinalizadoEm(),
                TextColor = Color.Gray,
                FontSize = 12
            };

            stackLayoutTitulo.Children.Add(labelTitulo);
            stackLayoutTitulo.Children.Add(labelFinalizado);

            var stackLayout = new StackLayout()
            {
                Spacing = 15,
                Orientation = StackOrientation.Horizontal
            };

            stackLayout.Children.Add(imagemCheck);
            stackLayout.Children.Add(stackLayoutTitulo);
            stackLayout.Children.Add(imagemPrioridade);
            stackLayout.Children.Add(imagemExcluir);

            return stackLayout;
        }

        private Image ObterImagemCheck(bool finalizado)
        {
            ImageSource source;

            if (finalizado)
            {
                source = ImageSource.FromFile(
                    Device.RuntimePlatform is "iOS"
                    ? "Images/check_on.png"
                    : "check_on.png"
                    );
            }
            else
            {
                source = ImageSource.FromFile(
                    Device.RuntimePlatform is "iOS"
                    ? "Images/check_off.png"
                    : "check_off.png"
                    );

            }

            var imagemCheck = new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                Source = source
            };

            return imagemCheck;
        }

        private Image ObterImagemPrioridade(string nomeImagemPrioridade)
        {
            var imagemPrioridade = new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                Source = ImageSource.FromFile(nomeImagemPrioridade)
            };

            return imagemPrioridade;
        }

        private Image ObterImagemExcluir(string nomeImagemExcluir)
        {
            var imagemExcluir = new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                Source = ImageSource.FromFile(nomeImagemExcluir)
            };

            return imagemExcluir;
        }
    }
}