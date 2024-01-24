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

        private void GoToActivityIndicatorPage(object sender, EventArgs e)
        {
            Detail = new ActivityIndicatorPage();
        }

        private void GoToProgressBarPage(object sender, EventArgs e)
        {
            Detail = new ProgressBarPage();
        }

        private void GoToBoxViewPage(object sender, EventArgs e)
        {
            Detail = new BoxViewPage();
        }

        private void GoToLabelPage(object sender, EventArgs e)
        {
            Detail = new LabelPage();
        }

        private void GoToButtonPage(object sender, EventArgs e)
        {
            Detail = new ButtonPage();
        }

        private void GoToEntryEditorPage(object sender, EventArgs e)
        {
            Detail = new EntryEditorPage();
        }

        private void GoToDatePickerPage(object sender, EventArgs e)
        {
            Detail = new DatePickerPage();
        }

        private void GoToTimePickerPage(object sender, EventArgs e)
        {
            Detail = new TimePickerPage();
        }

        private void GoToPickerPage(object sender, EventArgs e)
        {
            Detail = new PickerPage();
        }

        private void GoToSearchBarPage(object sender, EventArgs e)
        {
            Detail = new SearchBarPage();
        }

        private void GoToSliderStepperPage(object sender, EventArgs e)
        {
            Detail = new SliderStepperPage();
        }

        private void GoToSwitchPage(object sender, EventArgs e)
        {
            Detail = new SwitchPage();
        }
    }
}