using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using ns0;
using ns2;
using ns3;

namespace ns7;

internal static class Class25
{
	[CompilerGenerated]
	private sealed class Class26
	{
		public List<string> list_0;

		public List<string> list_1;

		public int int_0;

		public List<Ping> list_2;

		public void method_0()
		{
			foreach (string item in list_1)
			{
				Ping ping = new Ping();
				ping.PingCompleted += delegate(object sender, PingCompletedEventArgs e)
				{
					int_0--;
					if (!e.Cancelled && e.Error == null && e.Reply!.Status == IPStatus.Success)
					{
						list_0.Add(e.Reply!.Address.ToString());
					}
				};
				list_2.Add(ping);
				ping.SendAsync(item, null);
				int_0++;
				Thread.Sleep(10);
			}
		}

		public void method_1(object sender, PingCompletedEventArgs e)
		{
			int_0--;
			if (!e.Cancelled && e.Error == null && e.Reply!.Status == IPStatus.Success)
			{
				list_0.Add(e.Reply!.Address.ToString());
			}
		}
	}

	public static List<string> smethod_0(List<string> list_0)
	{
		List<string> list = new List<string>();
		try
		{
			foreach (string item in list_0)
			{
				try
				{
					Class43 @class = Class43.smethod_6(item);
					foreach (Class42 item2 in @class)
					{
						list.Add(item2.ToString());
					}
				}
				catch (Exception)
				{
				}
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	public static List<string> smethod_1()
	{
		List<string> list_0 = new List<string>();
		List<string> list_1 = smethod_2();
		int int_0 = 0;
		List<Ping> list_2 = new List<Ping>();
		IAsyncResult asyncResult = ((Delegate5)delegate
		{
			foreach (string item in list_1)
			{
				Ping ping = new Ping();
				ping.PingCompleted += delegate(object sender, PingCompletedEventArgs e)
				{
					int_0--;
					if (!e.Cancelled && e.Error == null && e.Reply!.Status == IPStatus.Success)
					{
						list_0.Add(e.Reply!.Address.ToString());
					}
				};
				list_2.Add(ping);
				ping.SendAsync(item, null);
				int_0++;
				Thread.Sleep(10);
			}
		}).BeginInvoke(null, null);
		asyncResult.AsyncWaitHandle.WaitOne();
		while (int_0 > 0)
		{
			Thread.Sleep(100);
		}
		foreach (Ping item2 in list_2)
		{
			item2.Dispose();
		}
		list_2.Clear();
		return list_0;
	}

	private static List<string> smethod_2()
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		IPAddress[] hostAddresses = Dns.GetHostAddresses(Environment.MachineName);
		IPAddress[] array = hostAddresses;
		foreach (IPAddress iPAddress in array)
		{
			if (iPAddress.AddressFamily != AddressFamily.InterNetwork)
			{
				continue;
			}
			string text = iPAddress.ToString();
			if (text == "127.0.0.1")
			{
				continue;
			}
			string text2 = smethod_3(text);
			if (list2.Contains(text2))
			{
				continue;
			}
			list2.Add(text2);
			for (int j = 0; j < 256; j++)
			{
				string text3 = string.Format(text2, j);
				if (text3 != text)
				{
					list.Add(text3);
				}
			}
		}
		return list;
	}

	private static string smethod_3(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string_0;
		}
		int num = string_0.LastIndexOf('.');
		if (num == -1)
		{
			return string_0;
		}
		return string_0.Substring(0, num + 1) + "{0}";
	}
}
