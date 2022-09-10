using System;
using System.ComponentModel;
using System.Globalization;

namespace FC2ServerLauncher;

public class EnumTimeLimitConverter : EnumConverter
{
	public EnumTimeLimitConverter()
		: base(typeof(ETimeLimit))
	{
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is string)
		{
			return (string)value switch
			{
				"Infinite" => ETimeLimit.Infinite, 
				"5 minutes" => ETimeLimit.Time5, 
				"10 minutes" => ETimeLimit.Time10, 
				"15 minutes" => ETimeLimit.Time15, 
				"20 minutes" => ETimeLimit.Time20, 
				"25 minutes" => ETimeLimit.Time25, 
				"30 minutes" => ETimeLimit.Time30, 
				"60 minutes" => ETimeLimit.Time60, 
				_ => ETimeLimit.Infinite, 
			};
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if ((object)destinationType == typeof(string) && value != null)
		{
			return (ETimeLimit)value switch
			{
				ETimeLimit.Infinite => "Infinite", 
				ETimeLimit.Time5 => "5 minutes", 
				ETimeLimit.Time10 => "10 minutes", 
				ETimeLimit.Time15 => "15 minutes", 
				ETimeLimit.Time20 => "20 minutes", 
				ETimeLimit.Time25 => "25 minutes", 
				ETimeLimit.Time30 => "30 minutes", 
				ETimeLimit.Time60 => "60 minutes", 
				_ => "Infinite", 
			};
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
