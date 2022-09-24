using System.Diagnostics;
using System.Threading;

namespace PbjBzLsVOvNrzQ;

public static class aYjATqRqhB
{
	public static void kCYMpRoUopW(string LoRUGWJjSZgXJ)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + LoRUGWJjSZgXJ);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}
}
