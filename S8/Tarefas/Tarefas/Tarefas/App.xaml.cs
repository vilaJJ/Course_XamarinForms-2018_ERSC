using Tarefas.Telas;
using Xamarin.Forms;

namespace Tarefas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new InicioPage())
            {
                BarBackgroundColor = Color.FromHex("#FF1414FF")
            };
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
