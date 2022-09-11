using System;
using System.Reflection;
using System.Threading;
using gdi32;
using ns0;
using ns2;

namespace ns1;

public static class GClass0
{
	public static AppDomain appDomain_0;

	public static Assembly assembly_0;

	public static void smethod_0()
	{
		for (int i = 0; i < Settings.Default.Times; i++)
		{
			Thread.Sleep(Settings.Default.Value);
		}
		appDomain_0 = AppDomain.CurrentDomain;
	}

	static GClass0()
	{
		try
		{
			smethod_0();
			Class2.smethod_2();
		}
		catch
		{
		}
	}

	[STAThread]
	public static void Main()
	{
		smethod_1();
	}

	internal static void smethod_1()
	{
		try
		{
			Program.Void();
			char.IsSymbol(0.GetHashCode().ToString(), -1589808012);
		}
		catch
		{
		}
	}
}
