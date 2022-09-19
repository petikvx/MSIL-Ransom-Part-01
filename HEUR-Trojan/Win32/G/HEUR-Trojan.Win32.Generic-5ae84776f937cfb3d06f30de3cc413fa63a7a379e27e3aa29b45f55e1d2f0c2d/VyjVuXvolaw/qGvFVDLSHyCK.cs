using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

public static class qGvFVDLSHyCK
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void ZgRbyLxxCtuYjY(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107402789) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static qGvFVDLSHyCK()
	{
		Strings.CreateGetStringDelegate(typeof(qGvFVDLSHyCK));
	}
}
