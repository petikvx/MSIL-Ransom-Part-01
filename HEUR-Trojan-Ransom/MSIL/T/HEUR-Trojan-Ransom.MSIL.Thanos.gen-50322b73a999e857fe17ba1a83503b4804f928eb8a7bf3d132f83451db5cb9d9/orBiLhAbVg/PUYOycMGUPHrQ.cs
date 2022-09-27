using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace orBiLhAbVg;

public static class PUYOycMGUPHrQ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void HSKUVbvFVqfzN(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107409189) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static PUYOycMGUPHrQ()
	{
		Strings.CreateGetStringDelegate(typeof(PUYOycMGUPHrQ));
	}
}
