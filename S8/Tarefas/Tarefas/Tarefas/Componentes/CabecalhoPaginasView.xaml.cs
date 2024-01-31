using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarefas.Componentes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CabecalhoPaginasView : ContentView
    {
        public CabecalhoPaginasView()
        {
            InitializeComponent();

            DefinirDataAtual();
        }

        private void DefinirDataAtual()
        {
            var dataAtual = DateTime.Now;

            var texto = dataAtual.ToString("dddd, dd/MM/yyyy").Normalize();

            Label_DataAtual.Text = texto;
        }
    }
}