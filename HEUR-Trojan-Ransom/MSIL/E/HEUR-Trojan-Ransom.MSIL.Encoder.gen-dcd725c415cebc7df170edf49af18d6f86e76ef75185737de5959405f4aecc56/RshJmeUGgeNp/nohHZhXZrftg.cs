using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace RshJmeUGgeNp;

public static class nohHZhXZrftg
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void CJftdBqBmL(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107404528) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static nohHZhXZrftg()
	{
		Strings.CreateGetStringDelegate(typeof(nohHZhXZrftg));
	}
}
