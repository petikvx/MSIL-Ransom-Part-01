using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;

namespace ns0;

internal class Class13
{
	private static Thread thread_0;

	private static List<Class3> list_0 = new List<Class3>();

	public static void smethod_0(Class3 class3_0)
	{
		list_0.Add(class3_0);
	}

	public static void smethod_1(Class3 class3_0)
	{
		list_0.Remove(class3_0);
	}

	public static void smethod_2()
	{
		thread_0 = new Thread(smethod_3);
		thread_0.Start();
	}

	private static void smethod_3()
	{
		new WebClient();
		while (true)
		{
			if (list_0.Count >= 1)
			{
				smethod_5();
				for (int i = 0; i < list_0.Count; i++)
				{
					if (i < list_0.Count && list_0[i] != null && list_0[i].Boolean_0)
					{
						list_0[i].method_7(new Class4(Class3.Enum0.const_18, Encoding.Default.GetBytes(smethod_5())).method_0());
					}
				}
				Thread.Sleep(TimeSpan.FromSeconds(60.0));
			}
			else
			{
				Thread.Sleep(5000);
			}
		}
	}

	public static void smethod_4()
	{
		if (thread_0 != null)
		{
			thread_0.Abort();
		}
	}

	private static string smethod_5()
	{
		try
		{
			WebClient webClient = new WebClient();
			double num = Environment.TickCount;
			webClient.DownloadData("http://google.com/");
			double num2 = Environment.TickCount;
			double num3 = Math.Floor(num2 - num) / 1000.0;
			Math.Round(num3, 0);
			double num4 = Math.Round(1024.0 / num3);
			return num4 + " KB\\Sec";
		}
		catch
		{
		}
		return "Error";
	}
}
