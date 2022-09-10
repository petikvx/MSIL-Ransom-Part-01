using System;
using System.ComponentModel;
using System.Globalization;

namespace FC2ServerLauncher;

public class EnumUploadRateConverter : EnumConverter
{
	public EnumUploadRateConverter()
		: base(typeof(EUploadRate))
	{
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is string)
		{
			return (string)value switch
			{
				"Unlimited" => EUploadRate.Unlimited, 
				"20 Kbps" => EUploadRate.Kbps20, 
				"40 Kbps" => EUploadRate.Kbps40, 
				"80 Kbps" => EUploadRate.Kbps80, 
				"160 Kbps" => EUploadRate.Kbps160, 
				"320 Kbps" => EUploadRate.Kbps320, 
				_ => EUploadRate.Unlimited, 
			};
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if ((object)destinationType == typeof(string) && value != null)
		{
			return (EUploadRate)value switch
			{
				EUploadRate.Unlimited => "Unlimited", 
				EUploadRate.Kbps20 => "20 Kbps", 
				EUploadRate.Kbps40 => "40 Kbps", 
				EUploadRate.Kbps80 => "80 Kbps", 
				EUploadRate.Kbps160 => "160 Kbps", 
				EUploadRate.Kbps320 => "320 Kbps", 
				_ => "Unlimited", 
			};
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
