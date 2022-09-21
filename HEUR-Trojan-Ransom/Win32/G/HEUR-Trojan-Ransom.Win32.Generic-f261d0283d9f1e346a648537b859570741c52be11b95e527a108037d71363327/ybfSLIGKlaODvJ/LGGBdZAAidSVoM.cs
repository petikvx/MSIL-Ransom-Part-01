using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ybfSLIGKlaODvJ;

public static class LGGBdZAAidSVoM
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void CaeCREdOuSqSgt(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107402780) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static LGGBdZAAidSVoM()
	{
		Strings.CreateGetStringDelegate(typeof(LGGBdZAAidSVoM));
	}
}
