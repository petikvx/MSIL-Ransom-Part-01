using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gtzdezosLTmcL;

public static class aObtPNamXvBoZ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void hhzrftGPpK(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107369032) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static aObtPNamXvBoZ()
	{
		Strings.CreateGetStringDelegate(typeof(aObtPNamXvBoZ));
	}
}
