using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace cmxGDwJsHiH;

public static class NqUkkIUPsfHDzq
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void PwiabXibfTTs(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107409208) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static NqUkkIUPsfHDzq()
	{
		Strings.CreateGetStringDelegate(typeof(NqUkkIUPsfHDzq));
	}
}
