using System.Diagnostics;
using System.Threading;

namespace Crypt_it;

public static class MutexHelper
{
	public static void CheckMutex(string myMutex)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + myMutex);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
