using System;
using System.Reflection;
using System.Security.Policy;
using ns5;
using ns6;

namespace ns0;

internal static class Class0
{
	[STAThread]
	public static int Main(string[] args)
	{
		if (Class34.smethod_0())
		{
			Class29.smethod_52();
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += Class29.smethod_206;
			return currentDomain.ExecuteAssemblyByName(new AssemblyName("w, version=0.0.0.0, culture=neutral, publickeytoken=null"), (Evidence)null, args);
		}
		int result = default(int);
		return result;
	}
}
