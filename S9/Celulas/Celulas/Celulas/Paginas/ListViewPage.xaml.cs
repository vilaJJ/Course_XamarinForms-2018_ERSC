using Celulas.Modelos;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Celulas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            IniciarFuncionarios();
        }

        private void IniciarFuncionarios()
        {
            var lista = new List<Funcionario>
            {
                new Funcionario("Juan Felipe Alves Flores", "Presidente"),
                new Funcionario("Kevin Matheus Queiroz Santana", "Vice-presidente"),
                new Funcionario("Bárbara Ohana Santos Silva", "Gerente do Jurídico"),
                new Funcionario("Maria Eduarda Batista Sousa", "Designer"),
                new Funcionario("Jefferson Ribeiro Vasconcelos Cunha", "Gerente Químico")
            };

            ListView_Funcionarios.ItemsSource = lista;
        }

        private void ListView_Funcionarios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var funcionario = e.SelectedItem as Funcionario;

            DisplayAlert(
                "Dados do funcionário",
                string.Format("Nome: {0}\n\nCargo: {1}", funcionario.Nome, funcionario.Cargo),
                "Ok"
                );
        }

        private void MenuItem_Funcionario_Licenca_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;

            var funcionario = menuItem.CommandParameter as Funcionario;

            DisplayAlert(
                "Licença do funcionário",
                string.Format("Licença aplicada para o funcionário '{0}'.", funcionario.Nome),
                "Ok"
                );
        }

        private void MenuItem_Funcionario_Ferias_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;

            var funcionario = menuItem.CommandParameter as Funcionario;

            DisplayAlert(
                "Férias do funcionário",
                string.Format("Férias aplicada para o funcionário '{0}'.", funcionario.Nome),
                "Ok"
                );
        }
    }
}