using Estilos.Pagina;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Estilos.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutMenu : FlyoutPage
    {
        public FlyoutMenu()
        {
            InitializeComponent();
        }

        private void Navegar(Page pagina)
        {
            Detail = new NavigationPage(pagina);
            IsPresented = false;
        }

        private void Button_ImplicitStyle_Clicked(object sender, System.EventArgs e)
        {
            Navegar(new ImplicitStylePage());
        }

        private void Button_ExplicitStyle_Clicked(object sender, System.EventArgs e)
        {
            Navegar(new ExplicitStylePage());
        }

        private void Button_GlobalStyle_Clicked(object sender, System.EventArgs e)
        {
            Navegar(new GlobalStylePage());
        }
    }
}