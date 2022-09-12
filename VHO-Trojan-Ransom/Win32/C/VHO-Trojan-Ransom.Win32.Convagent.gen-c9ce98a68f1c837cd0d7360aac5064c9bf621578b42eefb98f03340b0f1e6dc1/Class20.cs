using System;
using System.Globalization;
using System.Windows.Data;

internal class Class20 : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(bool)(value ?? ((object)false)))
		{
			return "Проверять вещи";
		}
		return "Остановить проверку";
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value != null && value.ToString() == "Остановить проверку";
	}

	public Class20()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
