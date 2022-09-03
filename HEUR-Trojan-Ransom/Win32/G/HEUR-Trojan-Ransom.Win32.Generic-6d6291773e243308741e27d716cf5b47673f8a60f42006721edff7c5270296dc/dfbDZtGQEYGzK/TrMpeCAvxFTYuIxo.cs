using System.Diagnostics;
using System.Threading;

namespace dfbDZtGQEYGzK;

public static class TrMpeCAvxFTYuIxo
{
	public static void uHtkocBrShyzfT(string ssIByKakRKJzkn)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + ssIByKakRKJzkn);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
