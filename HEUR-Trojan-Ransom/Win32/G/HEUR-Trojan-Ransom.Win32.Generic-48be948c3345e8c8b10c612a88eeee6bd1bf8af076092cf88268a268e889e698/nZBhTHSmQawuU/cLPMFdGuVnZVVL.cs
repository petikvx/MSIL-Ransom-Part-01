using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nZBhTHSmQawuU;

public static class cLPMFdGuVnZVVL
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void dlGyfFfAsareB(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107367544) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static cLPMFdGuVnZVVL()
	{
		Strings.CreateGetStringDelegate(typeof(cLPMFdGuVnZVVL));
	}
}
