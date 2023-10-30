#pragma warning disable CS0618 // Type or member is obsolete

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinLayouts.Pages;

namespace XamarinLayouts.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void GoToPage1(object sender, EventArgs eventArgs)
        {
            Detail = new NavigationPage(new Perfil1())
            {
                BarBackgroundColor = Color.FromHex("#FFC926"),
                BarTextColor = Color.Black
            };
            IsPresented = false;
        }

        private void GoToXamarinPage(object sender, EventArgs eventArgs) 
        {
            Detail = new NavigationPage(new Pages.Xamarin())
            {
                BarBackgroundColor = Color.FromHex("#FFC926"),
                BarTextColor = Color.Black
            };
            IsPresented = false;
        }
    }
}