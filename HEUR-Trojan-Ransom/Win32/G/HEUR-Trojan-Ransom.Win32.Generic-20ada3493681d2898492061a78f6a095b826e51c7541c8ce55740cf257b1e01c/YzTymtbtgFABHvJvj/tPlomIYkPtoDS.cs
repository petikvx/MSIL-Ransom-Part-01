using System.Diagnostics;
using System.Threading;

namespace YzTymtbtgFABHvJvj;

public static class tPlomIYkPtoDS
{
	public static void SWjYDLNpXKPQ(string bOMsvbibTGJ)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + bOMsvbibTGJ);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
