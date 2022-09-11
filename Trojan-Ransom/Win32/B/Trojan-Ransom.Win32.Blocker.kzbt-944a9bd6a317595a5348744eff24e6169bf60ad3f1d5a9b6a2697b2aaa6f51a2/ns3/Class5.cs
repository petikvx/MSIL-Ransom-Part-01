using System;

namespace ns3;

internal class Class5
{
	public static int int_0 = 9;

	public static int int_1 = 1;

	public static int int_2 = -1;

	public static int int_3 = 0;

	public static int int_4 = 8;

	private static int int_5 = 1;

	private static int int_6 = 4;

	private static int int_7 = 8;

	internal static int int_8 = 0;

	private static int int_9 = 1;

	internal static int int_10 = 16;

	private static int int_11 = 20;

	private static int int_12 = 28;

	private static int int_13 = 30;

	private static int int_14 = 127;

	internal int int_15;

	internal bool bool_0;

	internal int int_16;

	internal int int_17;

	internal Class11 class11_0;

	internal Class7 class7_0;

	public Class5()
		: this(int_2, bool_1: false)
	{
	}

	public Class5(int int_18, bool bool_1)
	{
		if (int_18 == int_2)
		{
			int_18 = 6;
		}
		else if (int_18 < int_3 || int_18 > int_0)
		{
			throw new ArgumentOutOfRangeException("lvl");
		}
		class11_0 = new Class11();
		class7_0 = new Class7(class11_0);
		bool_0 = bool_1;
		Class33.smethod_49(this, Enum0.const_0);
		Class33.smethod_65(this, int_18);
		Class33.smethod_105(this);
	}
}
