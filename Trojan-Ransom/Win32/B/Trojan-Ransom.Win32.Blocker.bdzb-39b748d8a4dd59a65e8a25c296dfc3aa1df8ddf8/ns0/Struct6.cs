namespace ns0;

internal struct Struct6
{
	internal uint uint_0;

	public void method_0()
	{
		uint_0 = 1024u;
	}

	public uint method_1(Class5 class5_0)
	{
		uint num = (class5_0.uint_0 >> 11) * uint_0;
		if (class5_0.uint_1 < num)
		{
			class5_0.uint_0 = num;
			uint_0 += 2048 - uint_0 >> 5;
			if (class5_0.uint_0 < 16777216)
			{
				class5_0.uint_1 = (class5_0.uint_1 << 8) | (byte)class5_0.stream_0.ReadByte();
				class5_0.uint_0 <<= 8;
			}
			return 0u;
		}
		class5_0.uint_0 -= num;
		class5_0.uint_1 -= num;
		uint_0 -= uint_0 >> 5;
		if (class5_0.uint_0 < 16777216)
		{
			class5_0.uint_1 = (class5_0.uint_1 << 8) | (byte)class5_0.stream_0.ReadByte();
			class5_0.uint_0 <<= 8;
		}
		return 1u;
	}
}
