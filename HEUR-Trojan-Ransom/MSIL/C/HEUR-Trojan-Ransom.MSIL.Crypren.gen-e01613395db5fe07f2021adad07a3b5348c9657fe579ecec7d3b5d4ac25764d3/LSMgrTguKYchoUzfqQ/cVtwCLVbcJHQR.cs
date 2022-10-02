using System.Diagnostics;
using System.Threading;

namespace LSMgrTguKYchoUzfqQ;

public static class cVtwCLVbcJHQR
{
	public static void ZoRzwZSxgZxhGm(string rbrerOshfgoUI)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + rbrerOshfgoUI);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
