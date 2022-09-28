using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace WEoqBCtavg;

public static class WOpCqnIcMVAuAS
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void RGVvkyVtTuNry(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107367853) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static WOpCqnIcMVAuAS()
	{
		Strings.CreateGetStringDelegate(typeof(WOpCqnIcMVAuAS));
	}
}
