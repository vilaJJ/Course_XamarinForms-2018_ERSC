using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mimica.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            BindingContext = new ViewModels.Inicio();
        }
    }
}