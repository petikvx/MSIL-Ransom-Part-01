using System;

namespace ns4;

internal class Class15
{
	public static bool smethod_0()
	{
		return smethod_2();
	}

	public static void smethod_1()
	{
		smethod_2();
	}

	private static bool smethod_2()
	{
		DateTime dateTime = DateTime.Parse("2013-11-15T14:22:58");
		if (!(DateTime.Now > dateTime) && !(DateTime.Now < dateTime.AddDays(-21.0)))
		{
			if (Class17.smethod_0() == null)
			{
				try
				{
					smethod_3();
				}
				catch
				{
				}
			}
			return true;
		}
		throw new Exception("This assembly has been built with an evaluation version of SmartAssembly, which has expired.");
	}

	private static void smethod_3()
	{
		Console.WriteLine("This assembly has been built with an evaluation version of SmartAssembly, and therefore cannot be distributed.");
	}
}
