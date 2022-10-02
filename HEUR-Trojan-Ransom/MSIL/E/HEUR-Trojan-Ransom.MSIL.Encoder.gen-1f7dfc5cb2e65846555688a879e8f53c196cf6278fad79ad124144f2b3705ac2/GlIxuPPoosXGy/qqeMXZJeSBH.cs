using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GlIxuPPoosXGy;

public static class qqeMXZJeSBH
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void djVBndqvWBQybZ(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107404590) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static qqeMXZJeSBH()
	{
		Strings.CreateGetStringDelegate(typeof(qqeMXZJeSBH));
	}
}
