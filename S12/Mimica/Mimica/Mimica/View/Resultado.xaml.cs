using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mimica.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resultado : ContentPage
    {
        public Resultado()
        {
            InitializeComponent();
            BindingContext = new ViewModels.Resultado();
        }
    }
}