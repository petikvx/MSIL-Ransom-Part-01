using System.Threading;

namespace PPK.NET;

internal class Issuer
{
	private static void PopCollection()
	{
		try
		{
			bool createdNew;
			using Mutex mutex = new Mutex(initiallyOwned: true, "TaRRaK", out createdNew);
			if (createdNew)
			{
				new Role().SearchCollection();
				mutex.ReleaseMutex();
			}
		}
		catch
		{
		}
	}

	public Issuer()
	{
		Class.SetupThread();
		base._002Ector();
	}
}
