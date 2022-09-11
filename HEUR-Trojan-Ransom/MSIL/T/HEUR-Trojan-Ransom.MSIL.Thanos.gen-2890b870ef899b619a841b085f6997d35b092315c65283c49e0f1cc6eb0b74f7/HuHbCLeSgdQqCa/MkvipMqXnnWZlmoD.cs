using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HuHbCLeSgdQqCa;

public static class MkvipMqXnnWZlmoD
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void UUaBKGpgiQoqR(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107411963) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static MkvipMqXnnWZlmoD()
	{
		Strings.CreateGetStringDelegate(typeof(MkvipMqXnnWZlmoD));
	}
}
