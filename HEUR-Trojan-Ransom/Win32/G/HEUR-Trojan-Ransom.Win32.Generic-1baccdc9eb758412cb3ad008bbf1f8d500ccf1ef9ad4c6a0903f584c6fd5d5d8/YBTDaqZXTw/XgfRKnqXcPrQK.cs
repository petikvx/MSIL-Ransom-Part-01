using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace YBTDaqZXTw;

public static class XgfRKnqXcPrQK
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void uDQbwYBAtKR(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107406953) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static XgfRKnqXcPrQK()
	{
		Strings.CreateGetStringDelegate(typeof(XgfRKnqXcPrQK));
	}
}
