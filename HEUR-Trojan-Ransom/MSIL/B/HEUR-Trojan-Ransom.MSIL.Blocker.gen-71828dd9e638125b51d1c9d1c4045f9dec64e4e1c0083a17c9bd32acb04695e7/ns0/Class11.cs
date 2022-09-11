using System;
using arma;

namespace ns0;

internal static class Class11
{
	public static AppDomain appDomain_0;

	static Class11()
	{
		appDomain_0 = AppDomain.CurrentDomain;
		AppDomain.CurrentDomain.AssemblyResolve += Class9.smethod_2;
	}

	[STAThread]
	private static void Main()
	{
		Program.Main();
	}
}
