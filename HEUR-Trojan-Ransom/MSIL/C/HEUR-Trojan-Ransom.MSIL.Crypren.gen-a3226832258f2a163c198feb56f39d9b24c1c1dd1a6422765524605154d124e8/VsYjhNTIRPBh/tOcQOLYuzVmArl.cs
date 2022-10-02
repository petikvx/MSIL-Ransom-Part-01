using System.Diagnostics;
using System.Threading;

namespace VsYjhNTIRPBh;

public static class tOcQOLYuzVmArl
{
	public static void WvINmMpTGSS(string OQvSnMNbwsrkB)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + OQvSnMNbwsrkB);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
