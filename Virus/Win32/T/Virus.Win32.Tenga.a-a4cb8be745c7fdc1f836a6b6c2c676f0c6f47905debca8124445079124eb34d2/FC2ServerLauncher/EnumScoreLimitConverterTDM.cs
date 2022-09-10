using System;
using System.ComponentModel;
using System.Globalization;

namespace FC2ServerLauncher;

public class EnumScoreLimitConverterTDM : EnumConverter
{
	public EnumScoreLimitConverterTDM()
		: base(typeof(EScoreLimitTDM))
	{
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is string)
		{
			return (string)value switch
			{
				"None" => EScoreLimitTDM.None, 
				"5" => EScoreLimitTDM.Score5, 
				"10" => EScoreLimitTDM.Score10, 
				"15" => EScoreLimitTDM.Score15, 
				"20" => EScoreLimitTDM.Score20, 
				"25" => EScoreLimitTDM.Score25, 
				"30" => EScoreLimitTDM.Score30, 
				"40" => EScoreLimitTDM.Score40, 
				"50" => EScoreLimitTDM.Score50, 
				"100" => EScoreLimitTDM.Score100, 
				"200" => EScoreLimitTDM.Score200, 
				_ => EScoreLimitTDM.None, 
			};
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if ((object)destinationType == typeof(string) && value != null)
		{
			return (EScoreLimitTDM)value switch
			{
				EScoreLimitTDM.None => "None", 
				EScoreLimitTDM.Score5 => "5", 
				EScoreLimitTDM.Score10 => "10", 
				EScoreLimitTDM.Score15 => "15", 
				EScoreLimitTDM.Score20 => "20", 
				EScoreLimitTDM.Score25 => "25", 
				EScoreLimitTDM.Score30 => "30", 
				EScoreLimitTDM.Score40 => "40", 
				EScoreLimitTDM.Score50 => "50", 
				EScoreLimitTDM.Score100 => "100", 
				EScoreLimitTDM.Score200 => "200", 
				_ => "None", 
			};
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
