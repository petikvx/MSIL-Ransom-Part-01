using System;
using System.Reflection;
using System.Threading;
using arma;

namespace BmHCcZGH;

internal static class Class9
{
	public static bool bool_0;

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

	static Class9()
	{
		if (smethod_0())
		{
			smethod_1();
			smethod_2();
			return;
		}
		Thread.Sleep(new Random().Next(80, 120));
		AppDomain.CurrentDomain.AssemblyResolve += delegate(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			AppDomain appDomain_ = (AppDomain)object_0;
			Assembly assembly_;
			return Class0.smethod_0(resolveEventArgs_0, appDomain_, out assembly_) ? assembly_ : null;
		};
	}

	[STAThread]
	private static int Main()
	{
		Program.Main();
		return 0;
	}
}
