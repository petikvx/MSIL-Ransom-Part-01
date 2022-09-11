using System.Diagnostics;
using System.Threading;

namespace oEqFtKwIikP;

public static class LNCIzyIyMbNxlM
{
	public static void adVkEKOGYVAbXNh(string svZUxPCsocY)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + svZUxPCsocY);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
