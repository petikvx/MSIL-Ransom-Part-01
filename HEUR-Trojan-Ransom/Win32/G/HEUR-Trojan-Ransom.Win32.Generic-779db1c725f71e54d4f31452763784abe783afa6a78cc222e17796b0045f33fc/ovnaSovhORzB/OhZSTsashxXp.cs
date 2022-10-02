using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ovnaSovhORzB;

public static class OhZSTsashxXp
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void OokEgSYHMrOun(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107476318) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static OhZSTsashxXp()
	{
		Strings.CreateGetStringDelegate(typeof(OhZSTsashxXp));
	}
}
