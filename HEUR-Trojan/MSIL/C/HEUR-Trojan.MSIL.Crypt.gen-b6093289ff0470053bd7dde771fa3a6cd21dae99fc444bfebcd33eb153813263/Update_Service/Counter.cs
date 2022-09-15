using System;
using System.Threading;

namespace Update_Service;

internal class Counter
{
	public static Random rsd = new Random();

	public static bool we()
	{
		Thread.Sleep(rsd.Next(10000, 20000));
		if (!"not state".Contains("sdf"))
		{
			Thread.Sleep(rsd.Next(20000, 25000));
			Program.InfoUpd();
		}
		return false;
	}

	public static string errors()
	{
		Thread.Sleep(rsd.Next(10000, 20000));
		if (!"not state".Contains("sdf"))
		{
			Thread.Sleep(rsd.Next(20000, 25000));
			Program.InfoUpd();
		}
		return "no error";
	}
}
