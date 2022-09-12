using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GfIOnzejDqtqB;

public static class UegAeYujoDEWE
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void CSrmlsQsVZwOGTp(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107406409) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static UegAeYujoDEWE()
	{
		Strings.CreateGetStringDelegate(typeof(UegAeYujoDEWE));
	}
}
