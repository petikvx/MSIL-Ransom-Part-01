using System.Diagnostics;
using System.Threading;

namespace JcxFVLIspytryi;

public static class DNCBnGsFhjhNdoE
{
	public static void enACHFOFZAw(string AfDbWqGIvZiwcC)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + AfDbWqGIvZiwcC);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
