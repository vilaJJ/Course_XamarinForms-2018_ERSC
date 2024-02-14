using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchBarPage : ContentPage
	{
		private readonly List<string> _pessoas;

		public SearchBarPage ()
		{
			InitializeComponent ();

            _pessoas = new List<string>()
            {
                "Juan Felipe Alves Flores",
                "Bárbara Ohana Santos Silva",
                "Maria Eduarda Batista Sousa",
                "Jefferson Ribeiro Vasconcelos Caralho",
                "Sara Ghabrielly Alma Penada"
            };

            StackLayout_ListaResultado_InicializarDados(_pessoas);
        }

        private void StackLayout_ListaResultado_InicializarDados(List<string> lista)
        {
            StackLayout_ListaResultado.Children.Clear();

            foreach (var item in lista)
            {
                var label = new Label { Text = item };
                StackLayout_ListaResultado.Children.Add(label);
            }
        }

        private void SearchBar_Pessoas_TextChanged(object sender, TextChangedEventArgs e)
        {
            var texto = e.NewTextValue.ToLower();
            var resultado = _pessoas.Where(
                                        pessoa => pessoa.ToLower().Contains(texto))
                                        .ToList();

            StackLayout_ListaResultado_InicializarDados(resultado);
        }
    }
}