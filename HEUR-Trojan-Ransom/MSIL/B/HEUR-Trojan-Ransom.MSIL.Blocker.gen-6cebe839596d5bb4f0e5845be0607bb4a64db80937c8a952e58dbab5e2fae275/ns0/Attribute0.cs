using System;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

internal sealed class Attribute0 : Attribute
{
	internal sealed class Class10
	{
		internal static void smethod_0(int int_0, char char_0, int int_1)
		{
			int num = 0;
			switch (((char_0 ^ int_1) - 14) ^ 0)
			{
			case 0:
				Thread.Sleep(int_0);
				break;
			}
			num++;
		}

		internal static Exception smethod_1(int int_0, char char_0, short short_0)
		{
			int num = 0;
			Exception result = (((char_0 ^ short_0) - 81) ^ 0) switch
			{
				0 => ProjectData.CreateProjectError(int_0), 
				_ => null, 
			};
			num++;
			return result;
		}
	}

	public Attribute0(string string_0)
	{
	}

	internal static int smethod_0<T>(T gparam_0, char char_0, short short_0) where T : string
	{
		int num = 0;
		int result = (((short_0 ^ char_0) - 79) ^ 0) switch
		{
			0 => Conversions.ToInteger((string)gparam_0), 
			1 => gparam_0.Length, 
			2 => Convert.ToInt32(gparam_0), 
			_ => 9, 
		};
		num++;
		return result;
	}
}
