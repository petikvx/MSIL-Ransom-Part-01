using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace zvenNXaGjQywAfJS;

public static class WBWuxeeaDKsQ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void JqmInKzmcqxyb(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107409528) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static WBWuxeeaDKsQ()
	{
		Strings.CreateGetStringDelegate(typeof(WBWuxeeaDKsQ));
	}
}
