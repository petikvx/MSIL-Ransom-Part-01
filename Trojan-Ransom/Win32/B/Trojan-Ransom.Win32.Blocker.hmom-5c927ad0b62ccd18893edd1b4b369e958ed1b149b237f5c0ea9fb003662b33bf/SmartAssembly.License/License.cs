using System;
using SmartAssembly.Shared;

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
		DateTime dateTime = DateTime.Parse("2015-08-15T01:09:01");
		if (!(DateTime.Now > dateTime) && !(DateTime.Now < dateTime.AddDays(-21.0)))
		{
			if (AppPathFinder.ReadInstalledSaPath() == null)
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
