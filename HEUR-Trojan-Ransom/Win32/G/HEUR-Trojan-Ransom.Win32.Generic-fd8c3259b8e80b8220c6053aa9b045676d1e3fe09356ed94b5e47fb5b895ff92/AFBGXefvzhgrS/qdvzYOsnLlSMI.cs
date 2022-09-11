using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace AFBGXefvzhgrS;

public static class qdvzYOsnLlSMI
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void ejHlboRELnPMj(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107390058) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static qdvzYOsnLlSMI()
	{
		Strings.CreateGetStringDelegate(typeof(qdvzYOsnLlSMI));
	}
}
