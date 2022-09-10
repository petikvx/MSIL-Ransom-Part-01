using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HSFBHZCtMXjPES;

public static class HjZRuOyGETBgL
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void aKhhPnHiXwcn(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107399284) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static HjZRuOyGETBgL()
	{
		Strings.CreateGetStringDelegate(typeof(HjZRuOyGETBgL));
	}
}
