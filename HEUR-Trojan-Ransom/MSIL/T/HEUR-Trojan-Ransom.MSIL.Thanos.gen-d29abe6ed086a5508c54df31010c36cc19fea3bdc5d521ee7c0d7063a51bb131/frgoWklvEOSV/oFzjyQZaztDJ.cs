using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public static class oFzjyQZaztDJ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void QdsUxwYDRCW(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107402593) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static oFzjyQZaztDJ()
	{
		Strings.CreateGetStringDelegate(typeof(oFzjyQZaztDJ));
	}
}
