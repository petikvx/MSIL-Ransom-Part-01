using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace xbot_wpf.Converters;

public class BooleanToVisibleConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		if ((!(bool?)value) ?? true)
		{
			return (object)new SolidColorBrush(Color.FromArgb((byte)0, (byte)38, (byte)135, (byte)251));
		}
		return Brushes.get_White();
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		return object.Equals(value, (object?)new SolidColorBrush(Color.FromArgb((byte)0, (byte)0, (byte)0, (byte)0)));
	}

	public BooleanToVisibleConverter()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
