using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace FEPAnxLYcpgz;

public static class eoHXJkPJdBHRTQ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void ZRebECvvGhUvLG(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107477277) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static eoHXJkPJdBHRTQ()
	{
		Strings.CreateGetStringDelegate(typeof(eoHXJkPJdBHRTQ));
	}
}
