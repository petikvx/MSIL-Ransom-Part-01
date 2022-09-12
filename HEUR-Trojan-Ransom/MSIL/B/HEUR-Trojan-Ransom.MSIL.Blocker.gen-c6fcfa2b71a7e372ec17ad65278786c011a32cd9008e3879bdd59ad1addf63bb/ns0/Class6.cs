using System;
using ns13;
using ns8;

namespace ns0;

internal class Class6 : Class5
{
	internal class Class4
	{
		internal readonly string string_0;

		internal readonly int int_0;

		internal Class4 class4_0;

		internal Class4(string string_1, int int_1, Class4 class4_1)
		{
			string_0 = string_1;
			int_0 = int_1;
			class4_0 = class4_1;
		}
	}

	internal static readonly int int_0;

	internal int int_1;

	internal Class4[] class4_0;

	internal int int_2 = 31;

	static Class6()
	{
		int_0 = Environment.TickCount;
	}

	public Class6()
	{
		class4_0 = new Class4[int_2 + 1];
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
		Class4 @class = class4_0[num3];
		while (true)
		{
			if (@class != null)
			{
				if (@class.int_0 == num && Class131.smethod_675(int_3, char_0, int_4, @class.string_0))
				{
					break;
				}
				@class = @class.class4_0;
				continue;
			}
			return null;
		}
		return @class.string_0;
	}
}
