using ControleXF.Menu;
using Xamarin.Forms;

namespace ControleXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Flyout();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
