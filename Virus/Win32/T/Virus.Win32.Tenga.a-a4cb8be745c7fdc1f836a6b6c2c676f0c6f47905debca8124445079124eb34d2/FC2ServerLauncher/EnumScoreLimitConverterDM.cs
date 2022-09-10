using System;
using System.ComponentModel;
using System.Globalization;

namespace FC2ServerLauncher;

public class EnumScoreLimitConverterDM : EnumConverter
{
	public EnumScoreLimitConverterDM()
		: base(typeof(EScoreLimitDM))
	{
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is string)
		{
			return (string)value switch
			{
				"None" => EScoreLimitDM.None, 
				"5" => EScoreLimitDM.Score5, 
				"10" => EScoreLimitDM.Score10, 
				"15" => EScoreLimitDM.Score15, 
				"20" => EScoreLimitDM.Score20, 
				"25" => EScoreLimitDM.Score25, 
				"30" => EScoreLimitDM.Score30, 
				"40" => EScoreLimitDM.Score40, 
				"50" => EScoreLimitDM.Score50, 
				"100" => EScoreLimitDM.Score100, 
				_ => EScoreLimitDM.None, 
			};
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if ((object)destinationType == typeof(string) && value != null)
		{
			return (EScoreLimitDM)value switch
			{
				EScoreLimitDM.None => "None", 
				EScoreLimitDM.Score5 => "5", 
				EScoreLimitDM.Score10 => "10", 
				EScoreLimitDM.Score15 => "15", 
				EScoreLimitDM.Score20 => "20", 
				EScoreLimitDM.Score25 => "25", 
				EScoreLimitDM.Score30 => "30", 
				EScoreLimitDM.Score40 => "40", 
				EScoreLimitDM.Score50 => "50", 
				EScoreLimitDM.Score100 => "100", 
				_ => "None", 
			};
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
