using System;
using System.Globalization;
using System.Windows.Data;

namespace xbot_wpf.Converters;

internal class TradesAcceptToText : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(bool)(value ?? ((object)false)))
		{
			return "Запустить";
		}
		return "Остановить";
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value != null && value.ToString() == "Остановить";
	}

	public TradesAcceptToText()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
