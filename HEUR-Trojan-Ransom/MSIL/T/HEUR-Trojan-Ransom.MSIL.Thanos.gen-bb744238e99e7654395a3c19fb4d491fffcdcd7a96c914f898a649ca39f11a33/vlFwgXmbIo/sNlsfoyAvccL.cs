using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace vlFwgXmbIo;

public static class sNlsfoyAvccL
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void PbgdRVjsXFFf(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107404576) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static sNlsfoyAvccL()
	{
		Strings.CreateGetStringDelegate(typeof(sNlsfoyAvccL));
	}
}
