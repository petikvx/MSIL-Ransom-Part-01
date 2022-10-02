using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UmXkJLRjSLdPF;

public static class ajKtzMBgWhV
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void NAQMBHczPgK(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107368262) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static ajKtzMBgWhV()
	{
		Strings.CreateGetStringDelegate(typeof(ajKtzMBgWhV));
	}
}
