using FakeStore.Converters;
using System;
using System.Globalization;
using Xamarin.Forms;


namespace FakeStore.ValueConverters
{
    [ValueConversion(typeof(Object), typeof(Object))]
    public class PrefixValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var input = value as string;
            var prefix = parameter as string;
            //return $"Category:  {input}";
            return $"{prefix}{input}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}