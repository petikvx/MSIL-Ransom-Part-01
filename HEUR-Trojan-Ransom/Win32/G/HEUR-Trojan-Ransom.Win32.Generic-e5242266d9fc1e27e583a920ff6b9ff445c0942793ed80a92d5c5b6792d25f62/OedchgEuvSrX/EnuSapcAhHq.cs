using System.Diagnostics;
using System.Threading;

namespace OedchgEuvSrX;

public static class EnuSapcAhHq
{
	public static void AJWcGsiTrAQmHr(string snzFsePENgCRmaq)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + snzFsePENgCRmaq);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
