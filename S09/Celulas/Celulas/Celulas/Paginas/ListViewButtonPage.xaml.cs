using Celulas.Modelos;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Celulas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewButtonPage : ContentPage
    {
        public ListViewButtonPage()
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

        private void Button_Ferias_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;

            var funcionario = button.CommandParameter as Funcionario;

            DisplayAlert(
                "Férias do funcionário",
                string.Format("Férias aplicada para '{0}'.", funcionario.Nome),
                "Ok"
                );
        }
    }
}