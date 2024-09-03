using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mimica.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Jogo : ContentPage
    {
        public Jogo()
        {
            InitializeComponent();
            BindingContext = new ViewModels.Jogo();
        }
    }
}