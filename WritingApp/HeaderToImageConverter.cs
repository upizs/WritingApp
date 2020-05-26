using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WritingApp
{
    /// <summary>
    /// Converts full path into specific image type
    /// </summary>
    [ValueConversion(typeof(string), typeof(BitmapImage))]
    class HeaderToImageConverter : IValueConverter
    {
        //create a new static instance of Converter
        public static HeaderToImageConverter Instance = new HeaderToImageConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        { 
            return new BitmapImage(new Uri($"pack://application:,,,/Images/{value}.png"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
