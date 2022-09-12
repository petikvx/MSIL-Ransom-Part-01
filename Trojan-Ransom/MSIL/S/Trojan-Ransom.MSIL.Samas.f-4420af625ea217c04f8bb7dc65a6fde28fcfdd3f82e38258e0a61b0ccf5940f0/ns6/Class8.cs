using System;
using ns1;

namespace ns6;

internal sealed class Class8
{
	internal static bool smethod_0()
	{
		DateTime dateTime = DateTime.Parse("2019-09-02T19:28:01");
		if (!(DateTime.Now > dateTime) && !(DateTime.Now < dateTime.AddDays(-21.0)))
		{
			if (Class32.smethod_84() == null)
			{
				try
				{
					smethod_1();
				}
				catch
				{
				}
			}
			return true;
		}
		throw new Exception(string.Format("This assembly has been built with SmartAssembly {0}, which has expired.", "Developer Edition"));
	}

	private static void smethod_1()
	{
		Console.WriteLine("This assembly has been built with SmartAssembly {0}, and therefore cannot be distributed.", "Developer Edition");
	}
}
