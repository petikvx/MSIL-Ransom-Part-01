using System.Diagnostics;
using System.Threading;

namespace vQzMGKHeycFziMq;

public static class PjJmBBFcROqRBW
{
	public static void NCUHNCZSansvafM(string vmwZIJOlliq)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + vmwZIJOlliq);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
