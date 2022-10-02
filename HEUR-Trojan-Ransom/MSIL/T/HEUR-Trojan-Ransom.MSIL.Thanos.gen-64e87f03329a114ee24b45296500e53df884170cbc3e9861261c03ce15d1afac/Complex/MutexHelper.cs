using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Complex;

public static class MutexHelper
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void CheckMutex(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107404147) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static MutexHelper()
	{
		Strings.CreateGetStringDelegate(typeof(MutexHelper));
	}
}
