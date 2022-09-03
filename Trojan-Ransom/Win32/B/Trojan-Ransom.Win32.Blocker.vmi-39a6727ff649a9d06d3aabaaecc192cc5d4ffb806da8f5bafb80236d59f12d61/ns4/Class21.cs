using System;
using System.Threading;
using ns1;
using ns2;
using ns3;

namespace ns4;

internal class Class21
{
	public static Class16 class16_0 = new Class16();

	public static Class22 class22_0 = new Class22();

	public static Class19 class19_0 = new Class19();

	public static Class20 class20_0 = new Class20();

	private static Class10 class10_0 = new Class10();

	private static Class9 class9_0 = new Class9();

	public static void Main(string[] args)
	{
		if (!class10_0.method_0())
		{
			Environment.Exit(-1);
		}
		class16_0.string_6 = class19_0.method_1();
		class16_0.string_8 = class19_0.method_0();
		class20_0.method_0();
		class9_0.method_0();
		smethod_0();
	}

	private static void smethod_0()
	{
		if (class16_0.bool_0)
		{
			try
			{
				Thread thread = new Thread(Class11.smethod_0);
				thread.Start();
			}
			catch
			{
			}
		}
	}
}
