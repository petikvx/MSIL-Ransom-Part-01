using System;
using System.Globalization;
using System.Windows.Data;

namespace xbot_wpf.Converters;

[ValueConversion(typeof(bool), typeof(bool))]
public class InverseBooleanConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (targetType != typeof(bool))
		{
			throw new InvalidOperationException("The target must be a boolean");
		}
		return !(bool)(value ?? ((object)false));
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotSupportedException();
	}

	public InverseBooleanConverter()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
