using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace qYAjLWajCJpnf;

public static class WWeQGTxUASTWH
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void ZGuWqxAqMy(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107459194) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static WWeQGTxUASTWH()
	{
		Strings.CreateGetStringDelegate(typeof(WWeQGTxUASTWH));
	}
}
