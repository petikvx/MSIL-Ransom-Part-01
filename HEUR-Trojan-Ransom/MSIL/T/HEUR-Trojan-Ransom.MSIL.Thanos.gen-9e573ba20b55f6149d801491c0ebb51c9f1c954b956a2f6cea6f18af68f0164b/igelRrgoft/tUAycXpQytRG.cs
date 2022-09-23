using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace igelRrgoft;

public static class tUAycXpQytRG
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void iHPpzmPygvM(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107406753) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static tUAycXpQytRG()
	{
		Strings.CreateGetStringDelegate(typeof(tUAycXpQytRG));
	}
}
