using System;
using System.Threading;

namespace ns0;

internal class Class10
{
	public static Class2 class2_0 = new Class2();

	public static Class11 class11_0 = new Class11();

	public static Class14 class14_0 = new Class14();

	public static Class3 class3_0 = new Class3();

	private static Class1 class1_0 = new Class1();

	private static Class0 class0_0 = new Class0();

	public static void Main(string[] args)
	{
		if (!class1_0.method_0())
		{
			Environment.Exit(-1);
		}
		class2_0.string_6 = class14_0.method_1();
		class2_0.string_8 = class14_0.method_0();
		class3_0.method_0();
		class0_0.method_0();
		smethod_0();
	}

	private static void smethod_0()
	{
		if (class2_0.bool_0)
		{
			try
			{
				Thread thread = new Thread(Class15.smethod_1);
				thread.Start();
			}
			catch
			{
			}
		}
	}
}
