using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgressBarPage : ContentPage
    {
        public ProgressBarPage()
        {
            InitializeComponent();
        }

        private void ModificarBarras(object sender, EventArgs e)
        {
            Bar1.Progress = 1;
            Bar2.ProgressTo(1, 500, Easing.Linear);
            Bar3.ProgressTo(1, 2000, Easing.CubicIn);
        }
    }
}