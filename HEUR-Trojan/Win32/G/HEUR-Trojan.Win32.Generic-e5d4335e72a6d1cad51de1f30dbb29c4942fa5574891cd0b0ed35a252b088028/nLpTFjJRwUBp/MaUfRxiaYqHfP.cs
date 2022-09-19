using System.Diagnostics;
using System.Threading;

namespace nLpTFjJRwUBp;

public static class MaUfRxiaYqHfP
{
	public static void fmaGOeNUmyoETh(string BSWcWymQEwopS)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + BSWcWymQEwopS);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
