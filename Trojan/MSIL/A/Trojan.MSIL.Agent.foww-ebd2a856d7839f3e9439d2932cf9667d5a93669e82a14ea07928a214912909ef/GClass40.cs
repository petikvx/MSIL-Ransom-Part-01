using System.Threading;

public static class GClass40
{
	private static Mutex mutex_0;

	public static bool smethod_0(string name)
	{
		mutex_0 = new Mutex(initiallyOwned: false, name, out var createdNew);
		return createdNew;
	}

	public static void smethod_1()
	{
		if (mutex_0 != null)
		{
			mutex_0.Close();
			mutex_0 = null;
		}
	}
}
