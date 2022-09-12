using System;
using ns1;

namespace ns3;

internal sealed class Class8
{
	internal static bool smethod_0()
	{
		DateTime dateTime = DateTime.Parse("2021-03-19T15:46:52");
		if (!(DateTime.Now > dateTime) && !(DateTime.Now < dateTime.AddDays(-21.0)))
		{
			if (Class11.smethod_24() == null)
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
		throw new Exception("This assembly has been built with SmartAssembly {8e7255a3-e84e-465e-88f6-44c3e2a09c55}, which has expired.");
	}

	private static void smethod_1()
	{
		Console.WriteLine(string.Format("This assembly has been built with SmartAssembly {0}, and therefore cannot be distributed.", "Personal Edition"));
	}
}
