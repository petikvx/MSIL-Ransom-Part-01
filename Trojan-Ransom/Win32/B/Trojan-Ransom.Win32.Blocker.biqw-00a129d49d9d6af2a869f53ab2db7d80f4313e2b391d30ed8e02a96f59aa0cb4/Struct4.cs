using ns3;

internal struct Struct4
{
	private uint uint_0;

	private static uint[] uint_1;

	static Struct4()
	{
		uint_1 = new uint[512];
		for (int num = 8; num >= 0; num--)
		{
			uint num2 = (uint)(1 << 9 - num - 1);
			uint num3 = (uint)(1 << 9 - num);
			for (uint num4 = num2; num4 < num3; num4++)
			{
				uint_1[num4] = (uint)(num << 6) + (num3 - num4 << 6 >> 9 - num - 1);
			}
		}
	}

	public void method_0()
	{
		uint_0 = 1024u;
	}

	public void method_1(uint uint_2)
	{
		if (uint_2 == 0)
		{
			uint_0 += 2048 - uint_0 >> 5;
		}
		else
		{
			uint_0 -= uint_0 >> 5;
		}
	}

	public void method_2(Class6 class6_0, uint uint_2)
	{
		uint num = (class6_0.uint_0 >> 11) * uint_0;
		if (uint_2 == 0)
		{
			class6_0.uint_0 = num;
			uint_0 += 2048 - uint_0 >> 5;
		}
		else
		{
			class6_0.ulong_0 += num;
			class6_0.uint_0 -= num;
			uint_0 -= uint_0 >> 5;
		}
		if (class6_0.uint_0 < 16777216)
		{
			class6_0.uint_0 <<= 8;
			class6_0.method_7();
		}
	}

	public uint method_3(uint uint_2)
	{
		return uint_1[(((uint_0 - uint_2) ^ (int)(0 - uint_2)) & 0x7FFL) >> 2];
	}

	public uint method_4()
	{
		return uint_1[uint_0 >> 2];
	}

	public uint method_5()
	{
		return uint_1[2048 - uint_0 >> 2];
	}
}
