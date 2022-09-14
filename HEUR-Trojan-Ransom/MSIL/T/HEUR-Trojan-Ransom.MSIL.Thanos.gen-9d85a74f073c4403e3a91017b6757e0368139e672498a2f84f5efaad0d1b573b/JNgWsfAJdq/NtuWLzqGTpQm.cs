using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace JNgWsfAJdq;

public static class NtuWLzqGTpQm
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void cMvmTEfErvbQ(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107364993) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static NtuWLzqGTpQm()
	{
		Strings.CreateGetStringDelegate(typeof(NtuWLzqGTpQm));
	}
}
