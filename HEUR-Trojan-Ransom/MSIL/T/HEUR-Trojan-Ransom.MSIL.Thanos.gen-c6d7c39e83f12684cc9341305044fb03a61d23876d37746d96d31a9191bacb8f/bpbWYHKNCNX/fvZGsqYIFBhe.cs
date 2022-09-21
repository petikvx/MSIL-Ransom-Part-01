using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bpbWYHKNCNX;

public static class fvZGsqYIFBhe
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void KtVPTdSBGuby(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107406114) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static fvZGsqYIFBhe()
	{
		Strings.CreateGetStringDelegate(typeof(fvZGsqYIFBhe));
	}
}
