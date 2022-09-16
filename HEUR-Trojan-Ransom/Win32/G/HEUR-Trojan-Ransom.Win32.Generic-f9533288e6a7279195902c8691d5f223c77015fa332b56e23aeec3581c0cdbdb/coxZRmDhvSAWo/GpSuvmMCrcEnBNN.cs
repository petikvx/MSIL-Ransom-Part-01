using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public static class GpSuvmMCrcEnBNN
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void hcOINnEUSDotta(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107401569) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static GpSuvmMCrcEnBNN()
	{
		Strings.CreateGetStringDelegate(typeof(GpSuvmMCrcEnBNN));
	}
}
