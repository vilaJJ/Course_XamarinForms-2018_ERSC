using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLayouts.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Perfil1 : ContentPage
    {
        private readonly string _sobre;

        public Perfil1()
        {
            InitializeComponent();

            _sobre = "Miguel de Icaza nasceu na Cidade do México e estudou na Universidade Nacional Autônoma do México (UNAM). Ele começou a escrever software em 1992.\nIcaza começou o projeto GNOME em Agosto de 1997. Ele e Frederico Mena, criaram um completo sistema de desktop livre e um componente para sistemas GNU/Linux. Antes disso, Icaza já havia trabalhado em um gerente de arquivos, o Midnight Commander, assim como no núcleo Linux.";

            LabelSobre.Text = _sobre;
        }
    }
}