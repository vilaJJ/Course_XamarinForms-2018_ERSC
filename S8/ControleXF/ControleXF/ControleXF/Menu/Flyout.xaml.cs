﻿using ControleXF.Controles;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Flyout : FlyoutPage
    {
        public Flyout()
        {
            InitializeComponent();
        }

        private void GoToActivityIndicatorPage(object sender, EventArgs e)
        {
            Detail = new ActivityIndicatorPage();
        }

        private void GoToProgressBarPage(object sender, EventArgs e)
        {
            Detail = new ProgressBarPage();
        }

        private void GoToBoxViewPage(object sender, EventArgs e)
        {
            Detail = new BoxViewPage();
        }

        private void GoToLabelPage(object sender, EventArgs e)
        {
            Detail = new LabelPage();
        }

        private void GoToButtonPage(object sender, EventArgs e)
        {
            Detail = new ButtonPage();
        }
    }
}