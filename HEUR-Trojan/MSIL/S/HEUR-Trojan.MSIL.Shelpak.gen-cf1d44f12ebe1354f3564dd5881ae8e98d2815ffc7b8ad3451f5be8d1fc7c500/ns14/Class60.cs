using System.Threading;
using ns17;

namespace ns14;

internal sealed class Class60
{
	public static string string_0 = "";

	public static string string_1;

	public static Thread thread_0 = new Thread(smethod_0);

	private static void smethod_0()
	{
		while (true)
		{
			Thread.Sleep(2000);
			string_1 = Class80.smethod_0();
			if (string_1 != string_0)
			{
				string_0 = string_1;
				Class84.smethod_0();
			}
		}
	}
}
