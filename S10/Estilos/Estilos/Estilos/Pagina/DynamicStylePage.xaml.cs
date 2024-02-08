using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Estilos.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DynamicStylePage : ContentPage
	{
		public DynamicStylePage ()
		{
			InitializeComponent ();
		}

        private void Button_Alterar_Clicked(object sender, EventArgs e)
        {
			var corAtual = (Color)Resources["Label_TextColor"];

			if (corAtual == Color.CadetBlue)
			{
                Resources["Label_TextColor"] = Color.DarkBlue;
                Resources["Label_FontAttributes"] = FontAttributes.Bold;
                Resources["Style_LabelTitle"] = Resources["Style_LabelCaption"];
            }
			else
			{
                Resources["Label_TextColor"] = Color.CadetBlue;
                Resources["Label_FontAttributes"] = FontAttributes.Bold | FontAttributes.Italic;
            }            
        }
    }
}