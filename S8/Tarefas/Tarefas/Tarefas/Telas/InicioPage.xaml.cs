using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarefas.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioPage : ContentPage
    {
        public InicioPage()
        {
            InitializeComponent();
        }

        private void Button_AdicionarTarefa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroPage());
        }
    }
}