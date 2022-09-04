using ns3;

namespace ns1;

internal struct Struct5
{
	public const int int_0 = 11;

	public const uint uint_0 = 2048u;

	private const int int_1 = 5;

	private uint uint_1;

	public void method_0(int int_2, uint uint_2)
	{
		if (uint_2 == 0)
		{
			uint_1 += 2048 - uint_1 >> int_2;
		}
		else
		{
			uint_1 -= uint_1 >> int_2;
		}
	}

	public void method_1()
	{
		uint_1 = 1024u;
	}

	public uint method_2(Class6 class6_0)
	{
		uint num = (class6_0.uint_1 >> 11) * uint_1;
		if (class6_0.uint_2 < num)
		{
			class6_0.uint_1 = num;
			uint_1 += 2048 - uint_1 >> 5;
			if (class6_0.uint_1 < 16777216)
			{
				class6_0.uint_2 = (class6_0.uint_2 << 8) | (byte)Class17.smethod_19(class6_0.stream_0, 39689);
				class6_0.uint_1 <<= 8;
			}
			return 0u;
		}
		class6_0.uint_1 -= num;
		class6_0.uint_2 -= num;
		uint_1 -= uint_1 >> 5;
		if (class6_0.uint_1 < 16777216)
		{
			class6_0.uint_2 = (class6_0.uint_2 << 8) | (byte)Class17.smethod_19(class6_0.stream_0, 39689);
			class6_0.uint_1 <<= 8;
		}
		return 1u;
	}
}
