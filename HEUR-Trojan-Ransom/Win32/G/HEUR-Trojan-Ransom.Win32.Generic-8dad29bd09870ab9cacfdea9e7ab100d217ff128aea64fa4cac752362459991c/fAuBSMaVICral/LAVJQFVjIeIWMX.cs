using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fAuBSMaVICral;

public static class LAVJQFVjIeIWMX
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void JijrRQeRNRqt(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107364660) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static LAVJQFVjIeIWMX()
	{
		Strings.CreateGetStringDelegate(typeof(LAVJQFVjIeIWMX));
	}
}
