using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace xbot_wpf.Converters;

public class PercentageConverter : MarkupExtension, IValueConverter
{
	private static PercentageConverter percentageConverter_0;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return System.Convert.ToDouble(value) * System.Convert.ToDouble(parameter);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return percentageConverter_0 ?? (percentageConverter_0 = new PercentageConverter());
	}

	public PercentageConverter()
	{
		Class24.nhQmSIPz7n4eU();
		((MarkupExtension)this)._002Ector();
	}
}
