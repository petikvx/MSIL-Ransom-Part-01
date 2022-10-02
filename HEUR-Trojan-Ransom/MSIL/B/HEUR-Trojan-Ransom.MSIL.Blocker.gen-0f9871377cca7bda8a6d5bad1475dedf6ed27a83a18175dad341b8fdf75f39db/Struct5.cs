internal struct Struct5
{
	private readonly Struct4[] struct4_0;

	private readonly int int_0;

	public Struct5(int int_1)
	{
		int_0 = int_1;
		struct4_0 = new Struct4[1 << int_1];
	}

	public void method_0()
	{
		for (uint num = 1u; num < 1 << int_0; num++)
		{
			struct4_0[num].method_0();
		}
	}

	public uint method_1(Class6 class6_0)
	{
		uint num = 1u;
		for (int num2 = int_0; num2 > 0; num2--)
		{
			num = (num << 1) + struct4_0[num].method_1(class6_0);
		}
		return num - (uint)(1 << int_0);
	}

	public uint method_2(Class6 class6_0)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_0; i++)
		{
			uint num3 = struct4_0[num].method_1(class6_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public static uint smethod_0(Struct4[] struct4_1, uint uint_0, Class6 class6_0, int int_1)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_1; i++)
		{
			uint num3 = struct4_1[uint_0 + num].method_1(class6_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}
}
