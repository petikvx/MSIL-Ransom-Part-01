using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

public static class KdKiCrKeuciOqG
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void HTkeHKTcTuYeMbW(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107403832) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static KdKiCrKeuciOqG()
	{
		Strings.CreateGetStringDelegate(typeof(KdKiCrKeuciOqG));
	}
}
