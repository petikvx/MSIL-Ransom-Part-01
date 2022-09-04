namespace ns1;

internal struct Struct4
{
	public const int int_0 = 11;

	public const uint uint_0 = 2048u;

	private const int int_1 = 5;

	private const int int_2 = 2;

	public const int int_3 = 6;

	private uint uint_1;

	private static uint[] uint_2;

	public void method_0()
	{
		uint_1 = 1024u;
	}

	public void method_1(uint uint_3)
	{
		if (uint_3 == 0)
		{
			uint_1 += 2048 - uint_1 >> 5;
		}
		else
		{
			uint_1 -= uint_1 >> 5;
		}
	}

	public void method_2(Class5 class5_0, uint uint_3)
	{
		uint num = (class5_0.uint_1 >> 11) * uint_1;
		if (uint_3 == 0)
		{
			class5_0.uint_1 = num;
			uint_1 += 2048 - uint_1 >> 5;
		}
		else
		{
			class5_0.ulong_0 += num;
			class5_0.uint_1 -= num;
			uint_1 -= uint_1 >> 5;
		}
		if (class5_0.uint_1 < 16777216)
		{
			class5_0.uint_1 <<= 8;
			class5_0.method_7();
		}
	}

	static Struct4()
	{
		uint_2 = new uint[512];
		for (int num = 8; num >= 0; num--)
		{
			uint num2 = (uint)(1 << 9 - num - 1);
			uint num3 = (uint)(1 << 9 - num);
			for (uint num4 = num2; num4 < num3; num4++)
			{
				uint_2[num4] = (uint)(num << 6) + (num3 - num4 << 6 >> 9 - num - 1);
			}
		}
	}

	public uint method_3(uint uint_3)
	{
		return uint_2[(((uint_1 - uint_3) ^ (int)(0 - uint_3)) & 0x7FFL) >> 2];
	}

	public uint method_4()
	{
		return uint_2[uint_1 >> 2];
	}

	public uint method_5()
	{
		return uint_2[2048 - uint_1 >> 2];
	}
}
