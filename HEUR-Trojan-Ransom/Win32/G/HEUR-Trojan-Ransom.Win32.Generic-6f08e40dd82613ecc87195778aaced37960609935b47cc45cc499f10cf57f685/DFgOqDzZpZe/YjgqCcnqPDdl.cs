using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace DFgOqDzZpZe;

public static class YjgqCcnqPDdl
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void BqcpUEBmaOqw(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107402373) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static YjgqCcnqPDdl()
	{
		Strings.CreateGetStringDelegate(typeof(YjgqCcnqPDdl));
	}
}
