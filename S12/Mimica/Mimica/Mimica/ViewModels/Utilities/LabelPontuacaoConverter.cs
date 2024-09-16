using System;
using System.Globalization;
using Xamarin.Forms;

namespace Mimica.ViewModels.Utilities
{
    internal class LabelPontuacaoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is 0)
            {
                return string.Empty;
            }

            return $"Pontuação: {value}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
