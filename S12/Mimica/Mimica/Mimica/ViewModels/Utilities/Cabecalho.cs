using System;
using Xamarin.Forms;

namespace Mimica.ViewModels.Utilities
{
    public class Cabecalho
    {
        #region Construtores

        public Cabecalho() { }

        #endregion

        #region Métodos Internos

        internal void ReiniciarAction()
        {
            Application.Current.MainPage = new Views.Inicio();
        }

        #endregion
    }
}
