using System.Threading;
using ns1;

namespace ns19;

public static class GClass23
{
	public static Mutex mutex_0;

	public static bool smethod_0()
	{
		mutex_0 = new Mutex(initiallyOwned: false, GClass10.string_9, out var createdNew);
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
