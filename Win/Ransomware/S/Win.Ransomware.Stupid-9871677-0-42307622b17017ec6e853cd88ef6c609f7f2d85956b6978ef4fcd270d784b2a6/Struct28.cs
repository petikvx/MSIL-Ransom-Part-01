internal struct Struct28
{
	private readonly Struct27[] struct27_0;

	private readonly int int_0;

	public Struct28(int int_1)
	{
		int_0 = int_1;
		struct27_0 = new Struct27[1 << int_1];
	}

	public void method_0()
	{
		for (uint num = 1u; num < 1 << int_0; num++)
		{
			struct27_0[num].method_0();
		}
	}

	public uint method_1(Class82 class82_0)
	{
		uint num = 1u;
		for (int num2 = int_0; num2 > 0; num2--)
		{
			num = (num << 1) + struct27_0[num].method_1(class82_0);
		}
		return num - (uint)(1 << int_0);
	}

	public uint method_2(Class82 class82_0)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_0; i++)
		{
			uint num3 = struct27_0[num].method_1(class82_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public static uint smethod_0(Struct27[] struct27_1, uint uint_0, Class82 class82_0, int int_1)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_1; i++)
		{
			uint num3 = struct27_1[uint_0 + num].method_1(class82_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}
}
