using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KXfHkplBSblOeZ;

public static class TKWQNdkfkJIyWR
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void WJWtERWezV(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107405032) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static TKWQNdkfkJIyWR()
	{
		Strings.CreateGetStringDelegate(typeof(TKWQNdkfkJIyWR));
	}
}
