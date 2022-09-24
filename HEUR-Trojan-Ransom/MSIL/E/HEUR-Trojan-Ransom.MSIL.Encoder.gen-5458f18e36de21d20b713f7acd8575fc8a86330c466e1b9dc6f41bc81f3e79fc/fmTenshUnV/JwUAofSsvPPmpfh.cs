using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fmTenshUnV;

public static class JwUAofSsvPPmpfh
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void JpSZGBMNUNXns(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107404943) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static JwUAofSsvPPmpfh()
	{
		Strings.CreateGetStringDelegate(typeof(JwUAofSsvPPmpfh));
	}
}
