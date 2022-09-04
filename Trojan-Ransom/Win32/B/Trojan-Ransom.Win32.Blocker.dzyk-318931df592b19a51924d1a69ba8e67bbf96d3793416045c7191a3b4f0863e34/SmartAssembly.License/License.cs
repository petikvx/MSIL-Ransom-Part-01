using System;
using ns1;

namespace SmartAssembly.License;

public class License
{
	public static bool Validate()
	{
		return smethod_0();
	}

	public static void ValidateDLL()
	{
		smethod_0();
	}

	private static bool smethod_0()
	{
		DateTime dateTime = DateTime.Parse("2014-03-10T01:00:02");
		if (!(DateTime.Now > dateTime) && !(DateTime.Now < dateTime.AddDays(-21.0)))
		{
			if (Class18.smethod_0() == null)
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
		throw new Exception("This assembly has been built with an evaluation version of SmartAssembly, which has expired.");
	}

	private static void smethod_1()
	{
		Console.WriteLine("This assembly has been built with an evaluation version of SmartAssembly, and therefore cannot be distributed.");
	}
}
