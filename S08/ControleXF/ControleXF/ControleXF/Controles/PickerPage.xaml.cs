using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerPage : ContentPage
	{
		public PickerPage()
		{
			InitializeComponent();
		}

        private void Picker_MarcasSmartphones_SelectedIndexChanged(object sender, EventArgs e)
        {
			Label_Resultado.Text = string.Format(
				"Marca Selecionada: {0} #{1}", 
				Picker_MarcasSmartphones.SelectedItem,
				Picker_MarcasSmartphones.SelectedIndex
				);
        }
    }
}