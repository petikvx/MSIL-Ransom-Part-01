internal struct Struct6
{
	private readonly Struct5[] struct5_0;

	private readonly int int_0;

	public Struct6(int int_1)
	{
		int_0 = int_1;
		struct5_0 = new Struct5[1 << int_1];
	}

	public void method_0()
	{
		for (uint num = 1u; num < 1 << int_0; num++)
		{
			struct5_0[num].method_0();
		}
	}

	public uint method_1(Class41 class41_0)
	{
		uint num = 1u;
		for (int num2 = int_0; num2 > 0; num2--)
		{
			num = (num << 1) + struct5_0[num].method_1(class41_0);
		}
		return num - (uint)(1 << int_0);
	}

	public uint method_2(Class41 class41_0)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_0; i++)
		{
			uint num3 = struct5_0[num].method_1(class41_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public static uint smethod_0(Struct5[] struct5_1, uint uint_0, Class41 class41_0, int int_1)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_1; i++)
		{
			uint num3 = struct5_1[uint_0 + num].method_1(class41_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}
}
