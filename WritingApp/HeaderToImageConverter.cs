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
            //get the full path
            var path = (string)value;

            //if the path is null, ignore
            if (path == null)
                return null;

            //get the name
            var name = MainWindow.GetFileFolderName(path);

            //by default the image is text file
            var image = "Images/file.png";

            //if the item is folder
            if (new FileInfo(path).Attributes.HasFlag(FileAttributes.Directory))
                image = "Images/folder.png";

            return new BitmapImage(new Uri($"pack://application:,,,/{image}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
