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

        private void Navegar(Page pagina)
        {
            Detail = new NavigationPage(pagina);
            IsPresented = false;
        }

        private void Button_TextCell_Clicked(object sender, EventArgs e)
        {
            Navegar(new TextCellPage());
        }        

        private void Button_ImageCell_Clicked(object sender, EventArgs e)
        {
            Navegar(new ImageCellPage());
        }

        private void Button_EntryCell_Clicked(object sender, EventArgs e)
        {
            Navegar(new EntryCellPage());
        }

        private void Button_SwitchCell_Clicked(object sender, EventArgs e)
        {
            Navegar(new SwitchCellPage());
        }

        private void Button_ViewCell_Clicked(object sender, EventArgs e)
        {
            Navegar(new ViewCellPage());
        }

        private void Button_ListView_Clicked(object sender, EventArgs e)
        {
            Navegar(new ListViewPage());
        }

        private void Button_ListViewButton_Clicked(object sender, EventArgs e)
        {
            Navegar(new ListViewButtonPage());
        }
    }
}