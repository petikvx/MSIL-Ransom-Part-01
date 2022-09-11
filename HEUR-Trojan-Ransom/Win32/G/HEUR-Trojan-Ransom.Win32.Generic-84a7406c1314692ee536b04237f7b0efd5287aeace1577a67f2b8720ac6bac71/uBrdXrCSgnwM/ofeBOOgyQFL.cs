using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

public static class ofeBOOgyQFL
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void FQKnVnTpJvqra(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107411740) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static ofeBOOgyQFL()
	{
		Strings.CreateGetStringDelegate(typeof(ofeBOOgyQFL));
	}
}
