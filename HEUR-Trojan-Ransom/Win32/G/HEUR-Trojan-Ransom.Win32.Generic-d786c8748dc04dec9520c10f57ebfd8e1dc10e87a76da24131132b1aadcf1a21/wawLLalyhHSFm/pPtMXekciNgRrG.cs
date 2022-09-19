using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wawLLalyhHSFm;

public static class pPtMXekciNgRrG
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void ABoSFgyzRs(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107401146) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static pPtMXekciNgRrG()
	{
		Strings.CreateGetStringDelegate(typeof(pPtMXekciNgRrG));
	}
}
