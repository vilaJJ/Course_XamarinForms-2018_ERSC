using Celulas.Paginas;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Celulas.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : FlyoutPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_TextCell_Clicked(object sender, EventArgs e)
        {
            Navegar(new TextCellPage());
        }

        private void Navegar(Page pagina)
        {
            Detail = new NavigationPage(pagina);
        }
    }
}