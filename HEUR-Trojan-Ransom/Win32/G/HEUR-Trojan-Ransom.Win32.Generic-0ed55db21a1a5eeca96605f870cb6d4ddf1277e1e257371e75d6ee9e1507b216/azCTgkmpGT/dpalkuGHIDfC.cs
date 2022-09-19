using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public static class dpalkuGHIDfC
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void oGSTDUMLXLD(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107380899) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static dpalkuGHIDfC()
	{
		Strings.CreateGetStringDelegate(typeof(dpalkuGHIDfC));
	}
}
