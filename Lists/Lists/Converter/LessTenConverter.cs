using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Lists.Converter
{
    public class LessTenConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int qunataty = 0;
            int disNum = (int)value;
            if (disNum < 10)
            {
                qunataty = 15;
            }
            return qunataty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
