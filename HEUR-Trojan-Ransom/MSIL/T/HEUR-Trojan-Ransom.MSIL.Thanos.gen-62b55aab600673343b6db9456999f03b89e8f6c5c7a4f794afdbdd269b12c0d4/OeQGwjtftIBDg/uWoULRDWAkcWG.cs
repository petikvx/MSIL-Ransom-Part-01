using System.Diagnostics;
using System.Threading;

namespace OeQGwjtftIBDg;

public static class uWoULRDWAkcWG
{
	public static void NQeuneBYnVyyFpF(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
