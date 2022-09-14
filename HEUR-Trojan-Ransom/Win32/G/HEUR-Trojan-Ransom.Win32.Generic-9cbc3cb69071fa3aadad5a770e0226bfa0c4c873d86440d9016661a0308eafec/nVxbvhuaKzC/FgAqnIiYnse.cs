using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nVxbvhuaKzC;

public static class FgAqnIiYnse
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void qQtEXlRJmBgw(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107410382) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static FgAqnIiYnse()
	{
		Strings.CreateGetStringDelegate(typeof(FgAqnIiYnse));
	}
}
