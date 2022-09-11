using System;
using System.Threading;
using arma;

namespace OlLP4ANbrNNh;

internal class Class5
{
	public static bool bool_0;

	private object object_0;

	private static string string_0;

	private static string string_1;

	public static bool smethod_0()
	{
		DateTime now = DateTime.Now;
		int num = new Random().Next(800, 1200);
		Thread.Sleep(num);
		if ((DateTime.Now - now).TotalMilliseconds < (double)num)
		{
			return true;
		}
		return false;
	}

	private static void smethod_1()
	{
		GC.Collect(0, GCCollectionMode.Forced);
		GC.WaitForFullGCComplete();
		GC.WaitForPendingFinalizers();
	}

	private static void smethod_2()
	{
		bool_0 = false;
		throw new BadImageFormatException((string?)null, (Exception?)null);
	}

	static Class5()
	{
		if (smethod_0())
		{
			smethod_1();
			smethod_2();
		}
		Thread.Sleep(new Random().Next(80, 120));
		Class3.smethod_0();
	}

	[STAThread]
	public static int Main()
	{
		Program.Main();
		return 0;
	}
}
