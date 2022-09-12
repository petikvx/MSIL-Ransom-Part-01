using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace xbot_wpf.Converters;

public class BooleanToColorConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		if (((bool?)value) ?? false)
		{
			return (object)new SolidColorBrush(Color.FromArgb(byte.MaxValue, (byte)38, (byte)135, (byte)251));
		}
		return (object)new SolidColorBrush(Color.FromArgb(byte.MaxValue, (byte)89, (byte)89, (byte)89));
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return object.Equals(value, Brushes.get_Green());
	}

	public BooleanToColorConverter()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
