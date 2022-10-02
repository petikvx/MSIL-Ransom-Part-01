using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace OlVheIVabxHnbNp;

public static class qSotBUwSvVGVY
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void cuoCVXdHOTK(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107408298) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static qSotBUwSvVGVY()
	{
		Strings.CreateGetStringDelegate(typeof(qSotBUwSvVGVY));
	}
}
