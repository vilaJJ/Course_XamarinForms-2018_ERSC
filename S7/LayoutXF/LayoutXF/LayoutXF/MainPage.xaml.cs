using LayoutXF.Layouts.Absolute;
using LayoutXF.Layouts.Grid;
using LayoutXF.Layouts.Relative;
using LayoutXF.Layouts.Scroll;
using LayoutXF.Layouts.Stack;
using System;
using Xamarin.Forms;

namespace LayoutXF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoPaginaAbsolute(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new AbsolutePage());
        }

        private void GoPaginaGrid(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new GridPage());
        }

        private void GoPaginaRelative(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new RelativePage());
        }

        private void GoPaginaScroll(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new ScrollPage());
        }

        private void GoPaginaStack(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new StackPage());
        }
    }
}
