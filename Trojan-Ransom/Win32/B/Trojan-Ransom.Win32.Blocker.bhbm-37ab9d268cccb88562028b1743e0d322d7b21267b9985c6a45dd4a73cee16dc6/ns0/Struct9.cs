using ns2;
using ns5;

namespace ns0;

internal struct Struct9
{
	internal uint uint_0;

	public void method_0()
	{
		uint_0 = 1024u;
	}

	public uint method_1(Class6 class6_0)
	{
		uint num = (class6_0.uint_0 >> 11) * uint_0;
		if (class6_0.uint_1 < num)
		{
			class6_0.uint_0 = num;
			uint_0 += 2048 - uint_0 >> 5;
			if (class6_0.uint_0 < 16777216)
			{
				class6_0.uint_1 = (class6_0.uint_1 << 8) | (byte)GClass2.smethod_0(class6_0.stream_0, 385, 469);
				class6_0.uint_0 <<= 8;
			}
			return 0u;
		}
		class6_0.uint_0 -= num;
		class6_0.uint_1 -= num;
		uint_0 -= uint_0 >> 5;
		if (class6_0.uint_0 < 16777216)
		{
			class6_0.uint_1 = (class6_0.uint_1 << 8) | (byte)GClass2.smethod_0(class6_0.stream_0, 61, 105);
			class6_0.uint_0 <<= 8;
		}
		return 1u;
	}

	static Struct9()
	{
		Class12.Class13.Class14.smethod_1();
		Class7.smethod_15();
		GClass1.smethod_7();
	}
}
