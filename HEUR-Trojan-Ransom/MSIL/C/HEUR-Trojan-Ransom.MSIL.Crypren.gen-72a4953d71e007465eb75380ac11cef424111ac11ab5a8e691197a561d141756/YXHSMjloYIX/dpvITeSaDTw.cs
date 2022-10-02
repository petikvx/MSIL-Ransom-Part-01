using System.Diagnostics;
using System.Threading;

namespace YXHSMjloYIX;

public static class dpvITeSaDTw
{
	public static void FVXDqUZalJsA(string pDkzNYEBen)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + pDkzNYEBen);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
