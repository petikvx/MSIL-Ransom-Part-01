using System;
using System.Threading;
using ___codefort;

internal sealed class Class8
{
	public static Class16 class16_0 = new Class16();

	public static Class21 class21_0 = new Class21();

	public static Class6 class6_0 = new Class6();

	public static Class4 class4_0 = new Class4();

	private static Class12 class12_0 = new Class12();

	private static Class9 class9_0 = new Class9();

	public static void Main(string[] args)
	{
		if (!class12_0.method_0())
		{
			Environment.Exit(-1);
		}
		class16_0.string_8 = class6_0.method_1();
		class16_0.string_10 = class6_0.method_0();
		class16_0.string_11 = class6_0.method_3();
		class4_0.method_0();
		class9_0.method_0();
		smethod_0();
	}

	private static void smethod_0()
	{
		if (class16_0.bool_4)
		{
			try
			{
				Thread thread = new Thread(GClass0.smethod_1);
				thread.Start();
			}
			catch
			{
			}
		}
	}
}
