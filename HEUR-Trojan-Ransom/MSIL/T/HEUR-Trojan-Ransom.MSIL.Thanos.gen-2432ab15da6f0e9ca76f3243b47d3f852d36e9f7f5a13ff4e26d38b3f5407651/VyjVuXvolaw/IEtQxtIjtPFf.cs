using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

public static class IEtQxtIjtPFf
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void JfxJOinZfPRYlih(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107403684) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static IEtQxtIjtPFf()
	{
		Strings.CreateGetStringDelegate(typeof(IEtQxtIjtPFf));
	}
}
