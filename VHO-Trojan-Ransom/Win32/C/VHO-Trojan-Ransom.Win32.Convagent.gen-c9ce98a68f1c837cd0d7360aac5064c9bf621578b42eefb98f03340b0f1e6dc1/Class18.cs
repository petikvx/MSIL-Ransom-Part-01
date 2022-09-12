using System;
using System.Globalization;
using System.Windows.Data;

internal class Class18 : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(bool)(value ?? ((object)false)))
		{
			return "Импорт базы сайта";
		}
		return "Остановить импорт";
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value != null && value.ToString() == "Остановить импорт";
	}

	public Class18()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
