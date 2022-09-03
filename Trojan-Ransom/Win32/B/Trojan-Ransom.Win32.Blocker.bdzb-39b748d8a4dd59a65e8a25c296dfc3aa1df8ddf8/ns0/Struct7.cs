namespace ns0;

internal struct Struct7
{
	internal Struct6[] struct6_0;

	internal int int_0;

	public Struct7(int int_1)
	{
		int num = (int_0 = int_1);
		Struct6[] array = (struct6_0 = new Struct6[1 << int_1]);
		Class5.smethod_10();
	}

	public void method_0()
	{
		for (uint num = 1u; num < 1 << int_0; num++)
		{
			struct6_0[num].method_0();
		}
	}

	public uint method_1(Class5 class5_0)
	{
		uint num = 1u;
		for (int num2 = int_0; num2 > 0; num2--)
		{
			num = (num << 1) + struct6_0[num].method_1(class5_0);
		}
		return num - (uint)(1 << int_0);
	}

	public uint method_2(Class5 class5_0)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_0; i++)
		{
			uint num3 = struct6_0[num].method_1(class5_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public static uint smethod_0(Struct6[] struct6_1, uint uint_0, Class5 class5_0, int int_1)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_1; i++)
		{
			uint num3 = struct6_1[uint_0 + num].method_1(class5_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		uint result = num2;
		GClass0.smethod_3();
		return result;
	}
}
