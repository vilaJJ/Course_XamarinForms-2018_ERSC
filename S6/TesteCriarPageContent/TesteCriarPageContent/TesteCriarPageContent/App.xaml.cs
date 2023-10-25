using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteCriarPageContent
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            // MainPage = new CampoLabelEntryView();
            MainPage = new AbsPage();
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
