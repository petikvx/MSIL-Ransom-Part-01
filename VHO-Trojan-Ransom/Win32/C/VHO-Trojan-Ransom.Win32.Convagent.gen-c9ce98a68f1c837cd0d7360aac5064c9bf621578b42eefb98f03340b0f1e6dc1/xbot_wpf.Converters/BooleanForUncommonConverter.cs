using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace xbot_wpf.Converters;

public class BooleanForUncommonConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		if (!(((bool?)value) ?? false))
		{
			return Brushes.get_DarkGray();
		}
		return (object)new SolidColorBrush(Color.FromArgb(byte.MaxValue, (byte)94, (byte)152, (byte)217));
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		return object.Equals(value, (object?)new SolidColorBrush(Color.FromArgb((byte)0, (byte)0, (byte)0, (byte)0)));
	}

	public BooleanForUncommonConverter()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
