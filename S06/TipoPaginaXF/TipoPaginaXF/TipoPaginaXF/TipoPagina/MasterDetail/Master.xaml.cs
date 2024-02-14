#pragma warning disable CS0618 // Type or member is obsolete

using System;
using TipoPaginaXF.TipoPagina.Navigation.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipoPaginaXF.TipoPagina.MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void MudarPagina1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina1());
            IsPresented = false;
        }

        private void MudarPagina2(object sender, EventArgs e)
        {
            Detail = new Pagina2();
            IsPresented = false;
        }

        private void MudarPagina3(object sender, EventArgs e)
        {
            Detail = new Conteudo();
            IsPresented = false;
        }
    }
}