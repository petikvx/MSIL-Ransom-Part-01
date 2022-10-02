using System.Diagnostics;
using System.Threading;

namespace MufMaOSvGyvz;

public static class MPimnsOrmpnAX
{
	public static void IjTKmPwIgCf(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
