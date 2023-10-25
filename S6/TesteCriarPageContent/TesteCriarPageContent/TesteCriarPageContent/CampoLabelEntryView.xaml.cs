using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteCriarPageContent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CampoLabelEntryView : ContentView
    {
        public CampoLabelEntryView()
        {
            InitializeComponent();

            // new Label();
        }
    }
}