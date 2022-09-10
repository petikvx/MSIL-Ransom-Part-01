using System;
using System.ComponentModel;
using System.Globalization;

namespace FC2ServerLauncher;

public class EnumScoreLimitConverterCTF : EnumConverter
{
	public EnumScoreLimitConverterCTF()
		: base(typeof(EScoreLimitCTF))
	{
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is string)
		{
			return (string)value switch
			{
				"None" => EScoreLimitCTF.None, 
				"3" => EScoreLimitCTF.Score3, 
				"5" => EScoreLimitCTF.Score5, 
				"10" => EScoreLimitCTF.Score10, 
				"20" => EScoreLimitCTF.Score20, 
				"30" => EScoreLimitCTF.Score30, 
				"40" => EScoreLimitCTF.Score40, 
				"50" => EScoreLimitCTF.Score50, 
				"100" => EScoreLimitCTF.Score100, 
				_ => EScoreLimitCTF.None, 
			};
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if ((object)destinationType == typeof(string) && value != null)
		{
			return (EScoreLimitCTF)value switch
			{
				EScoreLimitCTF.None => "None", 
				EScoreLimitCTF.Score3 => "3", 
				EScoreLimitCTF.Score5 => "5", 
				EScoreLimitCTF.Score10 => "10", 
				EScoreLimitCTF.Score20 => "20", 
				EScoreLimitCTF.Score30 => "30", 
				EScoreLimitCTF.Score40 => "40", 
				EScoreLimitCTF.Score50 => "50", 
				EScoreLimitCTF.Score100 => "100", 
				_ => "None", 
			};
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
