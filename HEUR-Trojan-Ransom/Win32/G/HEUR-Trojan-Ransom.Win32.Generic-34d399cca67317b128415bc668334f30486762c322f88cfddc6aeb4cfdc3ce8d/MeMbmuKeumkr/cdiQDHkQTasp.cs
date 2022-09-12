using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MeMbmuKeumkr;

public static class cdiQDHkQTasp
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void qXFCgkDZhGqN(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107368676) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static cdiQDHkQTasp()
	{
		Strings.CreateGetStringDelegate(typeof(cdiQDHkQTasp));
	}
}
