using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fTOyYuFiHboGKe;

public static class ONohAWpMbHUNwGn
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void QCglDBmRgIiuwf(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107406911) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static ONohAWpMbHUNwGn()
	{
		Strings.CreateGetStringDelegate(typeof(ONohAWpMbHUNwGn));
	}
}
