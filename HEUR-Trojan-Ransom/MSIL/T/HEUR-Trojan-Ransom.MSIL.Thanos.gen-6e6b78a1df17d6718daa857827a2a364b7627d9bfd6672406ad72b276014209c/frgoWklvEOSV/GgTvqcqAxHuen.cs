using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public static class GgTvqcqAxHuen
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void BeFWKOFLhEUG(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107402193) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static GgTvqcqAxHuen()
	{
		Strings.CreateGetStringDelegate(typeof(GgTvqcqAxHuen));
	}
}
