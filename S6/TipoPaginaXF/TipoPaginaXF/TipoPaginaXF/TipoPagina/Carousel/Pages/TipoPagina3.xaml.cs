using System;
// using TipoPaginaXF.TipoPagina.Navigation.Pages;
using TipoPaginaXF.TipoPagina.Tabbed;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipoPaginaXF.TipoPagina.Carousel.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipoPagina3 : ContentPage
    {
        public TipoPagina3()
        {
            InitializeComponent();
        }

        private void MudarPagina(object sender, EventArgs eventArgs)
        {
            /*
            Application.Current.MainPage = new NavigationPage(new Pagina1()) 
            {
                BackgroundColor = Color.LightBlue
            };
            */

            Application.Current.MainPage = new Abas();
        }
    }
}