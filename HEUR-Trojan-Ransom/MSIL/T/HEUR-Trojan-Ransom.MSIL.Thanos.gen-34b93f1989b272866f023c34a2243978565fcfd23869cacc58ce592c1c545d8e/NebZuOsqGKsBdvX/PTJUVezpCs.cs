using System.Diagnostics;
using System.Threading;

namespace NebZuOsqGKsBdvX;

public static class PTJUVezpCs
{
	public static void YnjOjfNpifK(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
