using System;
using System.ComponentModel;
using System.Globalization;

namespace FC2ServerLauncher;

public class EnumScoreLimitConverterVIP : EnumConverter
{
	public EnumScoreLimitConverterVIP()
		: base(typeof(EScoreLimitVIP))
	{
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is string)
		{
			return (string)value switch
			{
				"1" => EScoreLimitVIP.Score1, 
				"None" => EScoreLimitVIP.None, 
				_ => EScoreLimitVIP.None, 
			};
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if ((object)destinationType == typeof(string) && value != null)
		{
			return (EScoreLimitVIP)value switch
			{
				EScoreLimitVIP.None => "None", 
				EScoreLimitVIP.Score1 => "1", 
				_ => "None", 
			};
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
