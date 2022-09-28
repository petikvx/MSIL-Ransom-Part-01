internal struct Struct3
{
	private readonly Struct2[] struct2_0;

	private readonly int int_0;

	public Struct3(int int_1)
	{
		int_0 = int_1;
		struct2_0 = new Struct2[1 << int_1];
	}

	public void method_0()
	{
		for (uint num = 1u; num < 1 << int_0; num++)
		{
			struct2_0[num].method_0();
		}
	}

	public uint method_1(Class35 class35_0)
	{
		uint num = 1u;
		for (int num2 = int_0; num2 > 0; num2--)
		{
			num = (num << 1) + struct2_0[num].method_1(class35_0);
		}
		return num - (uint)(1 << int_0);
	}

	public uint method_2(Class35 class35_0)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_0; i++)
		{
			uint num3 = struct2_0[num].method_1(class35_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public static uint smethod_0(Struct2[] struct2_1, uint uint_0, Class35 class35_0, int int_1)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_1; i++)
		{
			uint num3 = struct2_1[uint_0 + num].method_1(class35_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}
}
