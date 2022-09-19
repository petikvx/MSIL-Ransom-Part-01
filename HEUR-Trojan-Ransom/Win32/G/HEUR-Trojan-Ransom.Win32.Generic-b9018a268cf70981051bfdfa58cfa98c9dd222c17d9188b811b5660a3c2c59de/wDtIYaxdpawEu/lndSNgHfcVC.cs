using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

public static class lndSNgHfcVC
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void hSNJkCWzxhJibq(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107380812) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static lndSNgHfcVC()
	{
		Strings.CreateGetStringDelegate(typeof(lndSNgHfcVC));
	}
}
