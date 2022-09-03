using System;
using System.Threading;
using ns1;
using ns3;

namespace ns2;

internal class Class20
{
	public static Class24 class24_0 = new Class24();

	public static Class15 class15_0 = new Class15();

	public static Class23 class23_0 = new Class23();

	public static Class9 class9_0 = new Class9();

	private static Class14 class14_0 = new Class14();

	private static Class22 class22_0 = new Class22();

	public static void Main(string[] args)
	{
		if (!class14_0.method_0())
		{
			Environment.Exit(-1);
		}
		class24_0.string_6 = class23_0.method_1();
		class24_0.string_8 = class23_0.method_0();
		class9_0.method_0();
		class22_0.method_0();
		smethod_0();
	}

	private static void smethod_0()
	{
		if (class24_0.bool_0)
		{
			try
			{
				Thread thread = new Thread(Class21.smethod_1);
				thread.Start();
			}
			catch
			{
			}
		}
	}
}
