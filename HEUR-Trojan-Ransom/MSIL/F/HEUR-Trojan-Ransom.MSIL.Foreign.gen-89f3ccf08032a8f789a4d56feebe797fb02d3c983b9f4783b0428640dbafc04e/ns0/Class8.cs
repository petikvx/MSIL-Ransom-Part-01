using System.Threading;

namespace ns0;

internal class Class8
{
	private static Mutex mutex_0;

	public static bool Boolean_0 => !mutex_0.WaitOne(0, exitContext: false);

	public static void smethod_0(string string_0)
	{
		if (mutex_0 == null)
		{
			mutex_0 = new Mutex(initiallyOwned: false, string_0);
		}
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
