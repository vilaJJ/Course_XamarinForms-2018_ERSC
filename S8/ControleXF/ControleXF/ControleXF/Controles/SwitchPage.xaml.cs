using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SwitchPage : ContentPage
	{
		public SwitchPage ()
		{
			InitializeComponent ();
		}

        private void Switch_Lampada_Toggled(object sender, ToggledEventArgs e)
        {
			Label_Lampada.Text = string.Format("Estado da Lâmpada: {0} ({1:HH:mm:ss})", e.Value, DateTime.Now);
        }
    }
}