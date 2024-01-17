using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerPage : ContentPage
    {
        public DatePickerPage()
        {
            InitializeComponent();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            Label_Resultado.Text = e.OldDate.ToString("dd/MM/yyyy") + " para " + e.NewDate.ToString("dd/MM/yyyy");
        }
    }
}