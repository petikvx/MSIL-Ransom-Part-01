internal struct Struct9
{
	private const int int_0 = 11;

	private const uint uint_0 = 2048u;

	private const int int_1 = 5;

	private uint uint_1;

	public void method_0()
	{
		uint_1 = 1024u;
	}

	public uint method_1(Class12 class12_0)
	{
		uint num = (class12_0.uint_2 >> 11) * uint_1;
		if (class12_0.uint_3 < num)
		{
			class12_0.uint_2 = num;
			uint_1 += 2048 - uint_1 >> 5;
			if (class12_0.uint_2 < 16777216)
			{
				class12_0.uint_3 = (class12_0.uint_3 << 8) | (byte)class12_0.stream_0.ReadByte();
				class12_0.uint_2 <<= 8;
			}
			return 0u;
		}
		class12_0.uint_2 -= num;
		class12_0.uint_3 -= num;
		uint_1 -= uint_1 >> 5;
		if (class12_0.uint_2 < 16777216)
		{
			class12_0.uint_3 = (class12_0.uint_3 << 8) | (byte)class12_0.stream_0.ReadByte();
			class12_0.uint_2 <<= 8;
		}
		return 1u;
	}
}
