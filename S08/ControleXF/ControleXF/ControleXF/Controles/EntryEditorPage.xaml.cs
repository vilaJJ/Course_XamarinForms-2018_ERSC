using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryEditorPage : ContentPage
    {
        public EntryEditorPage()
        {
            InitializeComponent();

            Entry_Principal.TextChanged += delegate (object sender, TextChangedEventArgs args)
            {
                Label_Informacao.Text = args.NewTextValue;
            };

            Editor_Comentario.Completed += delegate (object sender, EventArgs args)
            {
                var length = Editor_Comentario.Text.Length;

                Label_Length.Text = string.Format(
                    "{0} {1}", 
                    length, 
                    length == 1 ? "caracter" : "caracteres"
                    );
            };
        }
    }
}