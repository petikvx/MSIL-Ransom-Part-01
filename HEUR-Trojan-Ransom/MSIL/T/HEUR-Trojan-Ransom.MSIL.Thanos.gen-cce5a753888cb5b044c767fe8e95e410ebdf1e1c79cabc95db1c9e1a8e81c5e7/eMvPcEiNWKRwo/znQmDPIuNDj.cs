using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eMvPcEiNWKRwo;

public static class znQmDPIuNDj
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void ufMHTstqgeqYn(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107408230) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static znQmDPIuNDj()
	{
		Strings.CreateGetStringDelegate(typeof(znQmDPIuNDj));
	}
}
