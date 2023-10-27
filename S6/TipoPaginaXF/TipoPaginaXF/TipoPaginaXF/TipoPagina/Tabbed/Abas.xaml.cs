using TipoPaginaXF.TipoPagina.Carousel.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipoPaginaXF.TipoPagina.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Abas : TabbedPage
    {
        public Abas()
        {
            InitializeComponent();

            Children.Add(new TipoPagina1());
        }
    }
}