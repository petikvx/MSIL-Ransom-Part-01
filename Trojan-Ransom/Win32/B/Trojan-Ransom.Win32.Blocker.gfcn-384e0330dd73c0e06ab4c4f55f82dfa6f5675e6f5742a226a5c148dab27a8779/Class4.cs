using System;

internal class Class4
{
	public static bool smethod_0()
	{
		return smethod_1();
	}

	private static bool smethod_1()
	{
		DateTime dateTime = DateTime.Parse("2014-12-20T17:18:28");
		if (!(DateTime.Now > dateTime) && !(DateTime.Now < dateTime.AddDays(-21.0)))
		{
			if (Class2.smethod_0() == null)
			{
				try
				{
					smethod_2();
				}
				catch
				{
				}
			}
			return true;
		}
		throw new Exception("This assembly has been built with an evaluation version of SmartAssembly, which has expired.");
	}

	private static void smethod_2()
	{
		Console.WriteLine("This assembly has been built with an evaluation version of SmartAssembly, and therefore cannot be distributed.");
	}
}
