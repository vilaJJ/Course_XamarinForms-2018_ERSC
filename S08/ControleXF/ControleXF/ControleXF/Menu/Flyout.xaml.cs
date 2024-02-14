using ControleXF.Controles;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Flyout : FlyoutPage
    {
        public Flyout()
        {
            InitializeComponent();
        }

        private void Navegar(ContentPage pagina)
        {
            Detail = new NavigationPage(pagina);
            IsPresented = false;
        }

        private void GoToActivityIndicatorPage(object sender, EventArgs e)
        {
            Navegar(new ActivityIndicatorPage());
        }

        private void GoToProgressBarPage(object sender, EventArgs e)
        {
            Navegar(new ProgressBarPage());
        }

        private void GoToBoxViewPage(object sender, EventArgs e)
        {
            Navegar(new BoxViewPage());
        }

        private void GoToLabelPage(object sender, EventArgs e)
        {
            Navegar(new LabelPage());
        }

        private void GoToButtonPage(object sender, EventArgs e)
        {
            Navegar(new ButtonPage());
        }

        private void GoToEntryEditorPage(object sender, EventArgs e)
        {
            Navegar(new EntryEditorPage());
        }

        private void GoToDatePickerPage(object sender, EventArgs e)
        {
            Navegar(new DatePickerPage());
        }

        private void GoToTimePickerPage(object sender, EventArgs e)
        {
            Navegar(new TimePickerPage());
        }

        private void GoToPickerPage(object sender, EventArgs e)
        {
            Navegar(new PickerPage());
        }

        private void GoToSearchBarPage(object sender, EventArgs e)
        {
            Navegar(new SearchBarPage());
        }

        private void GoToSliderStepperPage(object sender, EventArgs e)
        {
            Navegar(new SliderStepperPage());
        }

        private void GoToSwitchPage(object sender, EventArgs e)
        {
            Navegar(new SwitchPage());
        }

        private void GoToImagePage(object sender, EventArgs e)
        {
            Navegar(new ImagePage());
        }
        
        private void GoToListViewPage(object sender, EventArgs e)
        {
            Navegar(new ListViewPage());
        }

        private void GoToTableViewPage(object sender, EventArgs e)
        {
            Navegar(new TableViewPage());
        }

        private void GoToWebViewPage(object sender, EventArgs e)
        {
            Navegar(new WebViewPage());
        }
    }
}