using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public static class NXknOtFEqo
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void vkxqBHwjWLV(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107348525) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static NXknOtFEqo()
	{
		Strings.CreateGetStringDelegate(typeof(NXknOtFEqo));
	}
}
