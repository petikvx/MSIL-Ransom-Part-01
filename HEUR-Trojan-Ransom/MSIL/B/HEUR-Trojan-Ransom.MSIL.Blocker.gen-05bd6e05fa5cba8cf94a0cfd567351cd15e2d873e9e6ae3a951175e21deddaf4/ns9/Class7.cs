using System;
using ns10;
using ns13;

namespace ns9;

internal class Class7 : Class6
{
	internal class Class5
	{
		internal readonly string string_0;

		internal readonly int int_0;

		internal Class5 class5_0;

		internal Class5(string string_1, int int_1, Class5 class5_1)
		{
			string_0 = string_1;
			int_0 = int_1;
			class5_0 = class5_1;
		}
	}

	internal static readonly int int_0;

	internal int int_1;

	internal Class5[] class5_0;

	internal int int_2 = 31;

	static Class7()
	{
		int_0 = Environment.TickCount;
	}

	public Class7()
	{
		class5_0 = new Class5[int_2 + 1];
	}

	public override string? vmethod_0(char[] char_0, int int_3, int int_4)
	{
		if (int_4 == 0)
		{
			return string.Empty;
		}
		int num = int_4 + int_0;
		num += (num << 7) ^ char_0[int_3];
		int num2 = int_3 + int_4;
		for (int i = int_3 + 1; i < num2; i++)
		{
			num += (num << 7) ^ char_0[i];
		}
		num -= num >> 17;
		num -= num >> 11;
		num -= num >> 5;
		int num3 = num & int_2;
		Class5 @class = class5_0[num3];
		while (true)
		{
			if (@class != null)
			{
				if (@class.int_0 == num && Class4.smethod_604(int_4, @class.string_0, int_3, char_0))
				{
					break;
				}
				@class = @class.class5_0;
				continue;
			}
			return null;
		}
		return @class.string_0;
	}
}
