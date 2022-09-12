internal struct Struct2
{
	private uint uint_0;

	public uint method_0(Class37 class37_0)
	{
		uint num = (class37_0.uint_0 >> 11) * uint_0;
		if (class37_0.uint_1 < num)
		{
			class37_0.uint_0 = num;
			uint_0 += 2048 - uint_0 >> 5;
			if (class37_0.uint_0 < 16777216)
			{
				class37_0.uint_1 = (class37_0.uint_1 << 8) | (byte)class37_0.stream_0.ReadByte();
				class37_0.uint_0 <<= 8;
			}
			return 0u;
		}
		class37_0.uint_0 -= num;
		class37_0.uint_1 -= num;
		uint_0 -= uint_0 >> 5;
		if (class37_0.uint_0 < 16777216)
		{
			class37_0.uint_1 = (class37_0.uint_1 << 8) | (byte)class37_0.stream_0.ReadByte();
			class37_0.uint_0 <<= 8;
		}
		return 1u;
	}

	public void method_1()
	{
		uint_0 = 1024u;
	}
}
