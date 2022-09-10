using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public static class GpSuvmMCrcEnBNN
{
	[NonSerialized]
	internal static GetString f00004c;

	public static void m000027(string p0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + p0);
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
