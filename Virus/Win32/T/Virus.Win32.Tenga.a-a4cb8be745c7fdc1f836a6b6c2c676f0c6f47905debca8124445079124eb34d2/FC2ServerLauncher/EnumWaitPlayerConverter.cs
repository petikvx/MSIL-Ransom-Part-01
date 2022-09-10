using System;
using System.ComponentModel;
using System.Globalization;

namespace FC2ServerLauncher;

public class EnumWaitPlayerConverter : EnumConverter
{
	public EnumWaitPlayerConverter()
		: base(typeof(EWaitReady))
	{
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is string)
		{
			return (string)value switch
			{
				"Wait All" => EWaitReady.WaitAll, 
				"Wait Majority" => EWaitReady.Wait50, 
				"Don't wait" => EWaitReady.WaitNone, 
				_ => EWaitReady.WaitNone, 
			};
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if ((object)destinationType == typeof(string) && value != null)
		{
			return (EWaitReady)value switch
			{
				EWaitReady.WaitNone => "Don't wait", 
				EWaitReady.Wait50 => "Wait Majority", 
				EWaitReady.WaitAll => "Wait All", 
				_ => "Don't wait", 
			};
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
