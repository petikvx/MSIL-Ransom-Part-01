using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UvfJgsTEpPeNG;

public static class CvbobzJarug
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void nqqqwmqqbmeZNY(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107370389) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static CvbobzJarug()
	{
		Strings.CreateGetStringDelegate(typeof(CvbobzJarug));
	}
}
