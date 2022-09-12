using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace sWduCclqEzKrM;

public static class ZhDmasxaJg
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void zbUWaWGTBFZK(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107379066) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static ZhDmasxaJg()
	{
		Strings.CreateGetStringDelegate(typeof(ZhDmasxaJg));
	}
}
