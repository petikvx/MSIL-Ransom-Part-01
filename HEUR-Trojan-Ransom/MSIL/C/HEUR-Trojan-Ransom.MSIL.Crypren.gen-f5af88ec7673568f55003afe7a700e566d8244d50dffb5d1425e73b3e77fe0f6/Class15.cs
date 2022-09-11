using System;
using System.IO;

internal sealed class Class15
{
	internal static Stream smethod_0(Stream stream_0)
	{
		if (stream_0 == null)
		{
			throw new InvalidOperationException(Class36.smethod_0("\ue582\ue581\ue582\ue585\ue58c\ue5c0\ue58d\ue5d2", 58848));
		}
		return Class50.smethod_0(stream_0);
	}

	internal static int smethod_1(int int_0)
	{
		return int_0 switch
		{
			104 => -24, 
			106 => -10, 
			107 => -27, 
			108 => -11, 
			109 => -17, 
			110 => -5, 
			114 => -31, 
			115 => -19, 
			116 => -9, 
			121 => -21, 
			122 => -25, 
			_ => -1, 
		};
	}
}
