using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public static class QPzeoGqYtJE
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void nwGoSxAmzjN(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107400570) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static QPzeoGqYtJE()
	{
		Strings.CreateGetStringDelegate(typeof(QPzeoGqYtJE));
	}
}
