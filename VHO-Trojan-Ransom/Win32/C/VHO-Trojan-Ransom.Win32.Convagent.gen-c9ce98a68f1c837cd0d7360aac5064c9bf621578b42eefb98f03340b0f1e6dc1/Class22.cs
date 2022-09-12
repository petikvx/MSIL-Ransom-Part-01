using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

internal class Class22 : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		if (((bool?)value) ?? false)
		{
			return (object)new SolidColorBrush(Color.FromArgb(byte.MaxValue, (byte)240, (byte)191, (byte)0));
		}
		return (object)new SolidColorBrush(Color.FromArgb((byte)0, (byte)0, (byte)0, (byte)0));
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return object.Equals(value, Brushes.get_Green());
	}

	public Class22()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
