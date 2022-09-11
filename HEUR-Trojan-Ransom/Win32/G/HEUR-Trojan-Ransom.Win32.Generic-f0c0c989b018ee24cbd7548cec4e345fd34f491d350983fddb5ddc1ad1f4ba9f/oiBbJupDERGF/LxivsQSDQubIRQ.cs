using System.Diagnostics;
using System.Threading;

namespace oiBbJupDERGF;

public static class LxivsQSDQubIRQ
{
	public static void ustSKkleyiFYz(string DJFHpLiEaC)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + DJFHpLiEaC);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
