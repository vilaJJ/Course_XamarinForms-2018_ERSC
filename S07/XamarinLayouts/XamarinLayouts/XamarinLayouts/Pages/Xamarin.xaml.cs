using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLayouts.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Xamarin : ContentPage
    {
        private readonly string _sobreXamarin;
        public Xamarin()
        {
            InitializeComponent();

            _sobreXamarin = "Comprada pela Microsoft em 2016.\nDesenvolve tecnologia multiplataforma que funcionam principalmente em Android, iOS e UWP (Universal Windows Platform).";

            LabelXamarin.Text = _sobreXamarin;
        }
    }
}