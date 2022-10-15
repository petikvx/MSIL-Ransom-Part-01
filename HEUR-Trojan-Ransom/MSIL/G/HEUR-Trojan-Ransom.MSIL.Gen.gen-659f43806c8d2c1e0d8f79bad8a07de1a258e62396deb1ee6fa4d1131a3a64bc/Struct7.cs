internal struct Struct7
{
	private readonly Struct6[] struct6_0;

	private readonly int int_0;

	public Struct7(int int_1)
	{
		int_0 = int_1;
		struct6_0 = new Struct6[1 << int_1];
	}

	public void method_0()
	{
		for (uint num = 1u; num < 1 << int_0; num++)
		{
			struct6_0[num].method_0();
		}
	}

	public uint method_1(Class8 class8_0)
	{
		uint num = 1u;
		for (int num2 = int_0; num2 > 0; num2--)
		{
			num = (num << 1) + struct6_0[num].method_1(class8_0);
		}
		return num - (uint)(1 << int_0);
	}

	public uint method_2(Class8 class8_0)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_0; i++)
		{
			uint num3 = struct6_0[num].method_1(class8_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public static uint smethod_0(Struct6[] struct6_1, uint uint_0, Class8 class8_0, int int_1)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_1; i++)
		{
			uint num3 = struct6_1[uint_0 + num].method_1(class8_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}
}
