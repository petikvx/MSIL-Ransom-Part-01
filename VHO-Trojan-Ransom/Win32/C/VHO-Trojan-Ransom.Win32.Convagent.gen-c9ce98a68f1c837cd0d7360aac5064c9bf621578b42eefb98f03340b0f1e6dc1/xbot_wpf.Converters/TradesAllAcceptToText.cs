using System;
using System.Globalization;
using System.Windows.Data;

namespace xbot_wpf.Converters;

internal class TradesAllAcceptToText : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(bool)(value ?? ((object)false)))
		{
			return "Вкл. на всех площадках";
		}
		return "Выкл. на всех площадках";
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value != null && value.ToString() == "Выкл. на всех площадках";
	}

	public TradesAllAcceptToText()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
