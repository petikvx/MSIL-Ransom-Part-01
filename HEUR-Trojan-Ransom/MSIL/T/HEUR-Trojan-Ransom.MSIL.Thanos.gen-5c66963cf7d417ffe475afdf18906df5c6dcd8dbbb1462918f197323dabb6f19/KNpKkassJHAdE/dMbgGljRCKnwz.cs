using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KNpKkassJHAdE;

public static class dMbgGljRCKnwz
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void cgzftOdwSMtdC(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107364862) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static dMbgGljRCKnwz()
	{
		Strings.CreateGetStringDelegate(typeof(dMbgGljRCKnwz));
	}
}
