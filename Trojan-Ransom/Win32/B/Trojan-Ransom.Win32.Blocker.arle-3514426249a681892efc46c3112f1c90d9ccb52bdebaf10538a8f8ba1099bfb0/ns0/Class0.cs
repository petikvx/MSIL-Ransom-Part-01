using System;
using System.Reflection;
using System.Security.Policy;

namespace ns0;

internal static class Class0
{
	[STAThread]
	public static int Main(string[] args)
	{
		Class1.smethod_36();
		AppDomain currentDomain = AppDomain.CurrentDomain;
		currentDomain.AssemblyResolve += Class1.smethod_28;
		return currentDomain.ExecuteAssemblyByName(new AssemblyName("3333, version=1.0.0.1, culture=neutral, publickeytoken=null"), (Evidence)null, args);
	}
}
