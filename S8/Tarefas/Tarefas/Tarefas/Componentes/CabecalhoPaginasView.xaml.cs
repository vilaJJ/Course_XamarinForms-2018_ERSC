using System;
using System.Globalization;
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
            var cultureInfo = new CultureInfo("pt-BR");

            var texto = dataAtual.ToString("dddd, dd/MM/yyyy", cultureInfo);
            texto = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto.ToLower());

            Label_DataAtual.Text = texto;
        }
    }
}