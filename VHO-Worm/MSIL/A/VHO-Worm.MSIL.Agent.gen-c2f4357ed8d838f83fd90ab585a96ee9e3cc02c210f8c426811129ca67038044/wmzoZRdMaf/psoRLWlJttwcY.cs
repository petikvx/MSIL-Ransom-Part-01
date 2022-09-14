using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wmzoZRdMaf;

public static class psoRLWlJttwcY
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void gtzhRzWsmqiqQH(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107404163) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static psoRLWlJttwcY()
	{
		Strings.CreateGetStringDelegate(typeof(psoRLWlJttwcY));
	}
}
