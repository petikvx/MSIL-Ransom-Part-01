using System;
using System.Globalization;
using System.Windows.Data;

internal class Class21 : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return (float)Math.Round(System.Convert.ToDouble(value), 0) / 100f;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		try
		{
			return System.Convert.ToSingle((value ?? ((object)0f)).ToString()!.Replace(".", ",")) * 100f;
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public Class21()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
