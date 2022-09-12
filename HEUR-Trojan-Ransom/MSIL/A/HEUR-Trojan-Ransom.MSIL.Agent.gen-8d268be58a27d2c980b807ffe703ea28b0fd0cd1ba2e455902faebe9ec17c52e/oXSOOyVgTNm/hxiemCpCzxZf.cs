using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace oXSOOyVgTNm;

public static class hxiemCpCzxZf
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void EtDhjBSiFga(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107401738) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static hxiemCpCzxZf()
	{
		Strings.CreateGetStringDelegate(typeof(hxiemCpCzxZf));
	}
}
