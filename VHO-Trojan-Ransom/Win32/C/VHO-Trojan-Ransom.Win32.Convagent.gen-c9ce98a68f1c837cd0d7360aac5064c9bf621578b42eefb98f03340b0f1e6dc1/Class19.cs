using System;
using System.Globalization;
using System.Windows.Data;

internal class Class19 : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(bool)(value ?? ((object)false)))
		{
			return "Запустить аналитику";
		}
		return "Остановить аналитику";
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value != null && value.ToString() == "Остановить аналитику";
	}

	public Class19()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
