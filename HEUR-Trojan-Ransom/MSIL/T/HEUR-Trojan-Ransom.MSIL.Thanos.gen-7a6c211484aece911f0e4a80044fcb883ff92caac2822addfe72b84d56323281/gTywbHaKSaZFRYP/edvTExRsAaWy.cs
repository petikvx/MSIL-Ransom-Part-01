using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gTywbHaKSaZFRYP;

public static class edvTExRsAaWy
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void UPSUGCEzFP(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107404385) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static edvTExRsAaWy()
	{
		Strings.CreateGetStringDelegate(typeof(edvTExRsAaWy));
	}
}
