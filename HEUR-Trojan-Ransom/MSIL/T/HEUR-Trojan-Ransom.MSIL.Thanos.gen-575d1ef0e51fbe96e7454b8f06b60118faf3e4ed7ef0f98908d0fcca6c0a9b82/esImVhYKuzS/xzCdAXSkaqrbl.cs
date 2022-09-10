using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace esImVhYKuzS;

public static class xzCdAXSkaqrbl
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void viQNPcTulCG(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107402849) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static xzCdAXSkaqrbl()
	{
		Strings.CreateGetStringDelegate(typeof(xzCdAXSkaqrbl));
	}
}
