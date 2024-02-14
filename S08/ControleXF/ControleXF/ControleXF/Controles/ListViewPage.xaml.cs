using ControleXF.Modelo;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		private readonly List<Pessoa> _pessoas;

		public ListViewPage ()
		{
			InitializeComponent ();

			_pessoas = new List<Pessoa>
			{
				new Pessoa("João Arthur", 20),
				new Pessoa("Vitor Araújo", 19),
				new Pessoa("Ana Leticia", 18),
				new Pessoa("Kevin Matheus", 21)
			};

			ListView_Pessoas.ItemsSource = _pessoas;
		}
	}
}