using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace drXPuaQNZPOSPCS;

public static class oVrGVIkTCPC
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void GimritvBSOn(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107402057) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static oVrGVIkTCPC()
	{
		Strings.CreateGetStringDelegate(typeof(oVrGVIkTCPC));
	}
}
