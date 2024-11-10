using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace swc_lab2.Converter
{
	public class ImageConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var isAtRegister = (bool)value;
			var uri = new Uri($"C:\\Users\\Роман3071\\RiderProjects\\swc_lab2\\swc_lab2.ui\\Resources\\Images\\IsAtRegister\\{isAtRegister}.png", UriKind.Absolute);
			var image = new BitmapImage(uri);
			return image;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
