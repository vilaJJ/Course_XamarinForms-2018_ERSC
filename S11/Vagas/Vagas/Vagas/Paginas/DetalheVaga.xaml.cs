using Vagas.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheVaga : ContentPage
    {
        public DetalheVaga(Vaga vaga)
        {
            InitializeComponent();

            CarregarDados(vaga);
        }

        private void CarregarDados(Vaga vaga)
        {
            BindingContext = vaga;
        }
    }
}