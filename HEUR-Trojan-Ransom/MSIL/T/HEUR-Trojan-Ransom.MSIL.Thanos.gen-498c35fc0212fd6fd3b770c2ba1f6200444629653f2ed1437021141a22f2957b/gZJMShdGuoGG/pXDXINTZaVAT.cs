using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gZJMShdGuoGG;

public static class pXDXINTZaVAT
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void RXgzVrndLpleAYD(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107407985) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static pXDXINTZaVAT()
	{
		Strings.CreateGetStringDelegate(typeof(pXDXINTZaVAT));
	}
}
