using System.Globalization;

namespace TrayectoriaEducativaGraficas.Converters
{
	public class NivelUnidadAnalisisToColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
			{
				return Colors.Black;
			}

			return value switch
			{
				"Avanzado" => Colors.Green,
				"Intermedio" => Colors.Yellow,
				"Básico" => Colors.Red,
				"Inicial" => Colors.Red,
				_ => Colors.White,
			};
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
