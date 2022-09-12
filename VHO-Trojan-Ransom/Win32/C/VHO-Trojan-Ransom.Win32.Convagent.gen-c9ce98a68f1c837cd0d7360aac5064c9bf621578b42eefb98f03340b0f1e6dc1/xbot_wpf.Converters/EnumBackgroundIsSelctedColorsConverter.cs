using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using xbot_wpf.Models;

namespace xbot_wpf.Converters;

public class EnumBackgroundIsSelctedColorsConverter : IValueConverter
{
	private string method_0(Enum enum_0)
	{
		BackgroundIsSelectedColorsAttribute backgroundIsSelectedColorsAttribute = enum_0.GetType().GetField(enum_0.ToString())!.GetCustomAttributes(inherit: true).OfType<BackgroundIsSelectedColorsAttribute>().SingleOrDefault();
		if (backgroundIsSelectedColorsAttribute != null)
		{
			return backgroundIsSelectedColorsAttribute.BackgroundIsSelectedColors;
		}
		return enum_0.ToString();
	}

	object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		ItemsType itemsType = ((ItemsType?)value) ?? ItemsType.ActiveBuy;
		return method_0(itemsType);
	}

	object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return string.Empty;
	}

	public EnumBackgroundIsSelctedColorsConverter()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
