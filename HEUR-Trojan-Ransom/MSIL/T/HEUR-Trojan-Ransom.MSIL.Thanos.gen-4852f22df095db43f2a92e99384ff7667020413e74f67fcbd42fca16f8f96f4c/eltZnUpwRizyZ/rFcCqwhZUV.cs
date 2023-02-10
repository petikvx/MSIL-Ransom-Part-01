using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eltZnUpwRizyZ;

public static class rFcCqwhZUV
{
	[NonSerialized]
	internal static GetString _0008;

	public static void PPGBbqZHDPyumOc(string P_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, _0008(107402227) + P_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static rFcCqwhZUV()
	{
		Strings.CreateGetStringDelegate(typeof(rFcCqwhZUV));
	}
}
