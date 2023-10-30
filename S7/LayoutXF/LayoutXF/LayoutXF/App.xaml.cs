using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()) 
            {
                Title = "Layouts no Xamarin.Forms"
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
