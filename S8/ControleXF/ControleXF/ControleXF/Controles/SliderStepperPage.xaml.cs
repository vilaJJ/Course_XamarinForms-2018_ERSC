using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SliderStepperPage : ContentPage
	{
		public SliderStepperPage ()
		{
			InitializeComponent ();
		}

        private void Slider_Idade_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Label_ResultadoSlider.Text = string.Format("Resultado Slider: {0}", e.NewValue);
        }

        private void Stepper_QuantidadeFilhos_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Label_ResultadoStepper.Text = string.Format("Resultado Stepper: {0}", e.NewValue);
        }
    }
}