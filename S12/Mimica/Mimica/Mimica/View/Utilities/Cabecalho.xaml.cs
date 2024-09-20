using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mimica.View.Utilities
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cabecalho : ContentView
    {
        private ViewModels.Utilities.Cabecalho Context
        {
            get => (ViewModels.Utilities.Cabecalho)BindingContext;
        }

        public Cabecalho()
        {
            InitializeComponent();
            BindingContext = new ViewModels.Utilities.Cabecalho();
        }

        private void ReiniciarEvent(object sender, System.EventArgs e)
        {
            Context.ReiniciarAction();
        }
    }
}