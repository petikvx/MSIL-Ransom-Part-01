using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace xbot_wpf.Converters;

public class BooleanForAncientConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		if (!(((bool?)value) ?? false))
		{
			return Brushes.get_DarkGray();
		}
		return (object)new SolidColorBrush(Color.FromArgb(byte.MaxValue, (byte)235, (byte)75, (byte)75));
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		return object.Equals(value, (object?)new SolidColorBrush(Color.FromArgb((byte)0, (byte)0, (byte)0, (byte)0)));
	}

	public BooleanForAncientConverter()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
