using System;

namespace ns6;

internal sealed class Class5
{
	internal static bool smethod_0()
	{
		DateTime dateTime = DateTime.Parse("2019-05-26T05:14:37");
		if (!(DateTime.Now > dateTime) && !(DateTime.Now < dateTime.AddDays(-21.0)))
		{
			if (Class3.smethod_133() == null)
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
