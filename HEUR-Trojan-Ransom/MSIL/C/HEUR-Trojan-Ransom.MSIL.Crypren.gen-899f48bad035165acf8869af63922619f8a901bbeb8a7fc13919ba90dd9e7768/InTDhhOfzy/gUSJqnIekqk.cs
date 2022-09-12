using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace InTDhhOfzy;

public static class gUSJqnIekqk
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void VsfCrimVAxMZ(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107409082) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static gUSJqnIekqk()
	{
		Strings.CreateGetStringDelegate(typeof(gUSJqnIekqk));
	}
}
