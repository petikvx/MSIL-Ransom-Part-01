using System.Diagnostics;
using System.Threading;

namespace tmhhYTpfSQZiU;

public static class SegQrtqOLb
{
	public static void jmqLkNnqQNUjn(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
