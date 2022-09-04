using ns2;
using ns5;

namespace ns0;

internal struct Struct10
{
	internal Struct9[] struct9_0;

	internal int int_0;

	public Struct10(int int_1)
	{
		int num = (int_0 = int_1);
		Struct9[] array = (struct9_0 = new Struct9[1 << int_1]);
	}

	public void method_0()
	{
		for (uint num = 1u; num < 1 << int_0; num++)
		{
			struct9_0[num].method_0();
		}
	}

	public uint method_1(Class6 class6_0)
	{
		uint num = 1u;
		for (int num2 = int_0; num2 > 0; num2--)
		{
			num = (num << 1) + struct9_0[num].method_1(class6_0);
		}
		return num - (uint)(1 << int_0);
	}

	public uint method_2(Class6 class6_0)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_0; i++)
		{
			uint num3 = struct9_0[num].method_1(class6_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public static uint smethod_0(Struct9[] struct9_1, uint uint_0, Class6 class6_0, int int_1)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < int_1; i++)
		{
			uint num3 = struct9_1[uint_0 + num].method_1(class6_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	static Struct10()
	{
		Class12.Class13.Class14.smethod_1();
		Class7.smethod_15();
		GClass1.smethod_7();
	}
}
