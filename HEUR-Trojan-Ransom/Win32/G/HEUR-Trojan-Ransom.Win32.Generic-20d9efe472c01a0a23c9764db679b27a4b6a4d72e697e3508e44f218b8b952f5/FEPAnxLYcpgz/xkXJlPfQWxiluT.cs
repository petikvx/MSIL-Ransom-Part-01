using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace FEPAnxLYcpgz;

public static class xkXJlPfQWxiluT
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void YTIOKUmGzmuc(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107446683) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static xkXJlPfQWxiluT()
	{
		Strings.CreateGetStringDelegate(typeof(xkXJlPfQWxiluT));
	}
}
