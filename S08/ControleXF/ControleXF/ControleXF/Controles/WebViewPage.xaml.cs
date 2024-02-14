using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebViewPage : ContentPage
	{
		public WebViewPage ()
		{
			InitializeComponent ();
            ConfigurarTextoBotoes();
		}

        private void ConfigurarTextoBotoes()
        {
            Button_Proximo.Text = ">";
            Button_Voltar.Text = "<";
        }

        private void ControlarBotoesNavegacao()
        {
            var isEnabledProximo = WebView_Browser.CanGoForward;
            var isEnabledVoltar = WebView_Browser.CanGoBack;

            Button_Proximo.IsEnabled = isEnabledProximo;
            Button_Voltar.IsEnabled = isEnabledVoltar;
        }

        private void Button_Navegar_Clicked(object sender, EventArgs e)
        {
            var enderecoDigitado = Entry_EnderecoSite.Text;
            WebView_Browser.Source = enderecoDigitado;
        }

        private void Button_Proximo_Clicked(object sender, EventArgs e)
        {
            if (WebView_Browser.CanGoForward is false)
            {
                return;
            }

            WebView_Browser.GoForward();
        }

        private void Button_Voltar_Clicked(object sender, EventArgs e)
        {
            if (WebView_Browser.CanGoBack is false)
            {
                return;
            }

            WebView_Browser.GoBack();
        }

        private void WebView_Browser_Navigating(object sender, WebNavigatingEventArgs e)
        {
            Label_Status.Text = string.Format("Carregando '{0}'", e.Url);
        }

        private void WebView_Browser_Navigated(object sender, WebNavigatedEventArgs e)
        {
            Label_Status.Text = string.Format("'{0}' carregado.", e.Url);
            Entry_EnderecoSite.Text = e.Url;
            ControlarBotoesNavegacao();
        }

        private void Entry_EnderecoSite_Completed(object sender, EventArgs e)
        {
            Button_Navegar_Clicked(null, null);
        }
    }
}