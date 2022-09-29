using System;

internal static class Class3
{
	private const int int_0 = 32;

	internal static void smethod_0(uint[] uint_0)
	{
		int i = 0;
		uint num = 0u;
		for (; i < uint_0.Length; i++)
		{
			num = (uint_0[i] = ~uint_0[i] + 1);
			if (num != 0)
			{
				i++;
				break;
			}
		}
		if (num != 0)
		{
			for (; i < uint_0.Length; i++)
			{
				uint_0[i] = ~uint_0[i];
			}
		}
		else
		{
			uint_0 = smethod_1(uint_0, uint_0.Length + 1);
			uint_0[^1] = 1u;
		}
	}

	private static uint[] smethod_1(uint[] uint_0, int int_1)
	{
		if (uint_0.Length == int_1)
		{
			return uint_0;
		}
		uint[] array = new uint[int_1];
		int num = Math.Min(uint_0.Length, int_1);
		for (int i = 0; i < num; i++)
		{
			array[i] = uint_0[i];
		}
		return array;
	}

	internal static void smethod_2<T>(ref T gparam_0, ref T gparam_1)
	{
		T val = gparam_0;
		gparam_0 = gparam_1;
		gparam_1 = val;
	}

	internal static ulong smethod_3(uint uint_0, uint uint_1)
	{
		return ((ulong)uint_0 << 32) | uint_1;
	}

	internal static uint smethod_4(ulong ulong_0)
	{
		return (uint)ulong_0;
	}

	internal static uint smethod_5(ulong ulong_0)
	{
		return (uint)(ulong_0 >> 32);
	}

	private static uint smethod_6(uint uint_0, uint uint_1)
	{
		return ((uint_0 << 7) | (uint_0 >> 25)) ^ uint_1;
	}

	internal static int smethod_7(int int_1, int int_2)
	{
		return (int)smethod_6((uint)int_1, (uint)int_2);
	}

	internal static int smethod_8(uint uint_0)
	{
		if (uint_0 == 0)
		{
			return 32;
		}
		int num = 0;
		if ((uint_0 & 0xFFFF0000u) == 0)
		{
			num += 16;
			uint_0 <<= 16;
		}
		if ((uint_0 & 0xFF000000u) == 0)
		{
			num += 8;
			uint_0 <<= 8;
		}
		if ((uint_0 & 0xF0000000u) == 0)
		{
			num += 4;
			uint_0 <<= 4;
		}
		if ((uint_0 & 0xC0000000u) == 0)
		{
			num += 2;
			uint_0 <<= 2;
		}
		if ((uint_0 & 0x80000000u) == 0)
		{
			num++;
		}
		return num;
	}
}
