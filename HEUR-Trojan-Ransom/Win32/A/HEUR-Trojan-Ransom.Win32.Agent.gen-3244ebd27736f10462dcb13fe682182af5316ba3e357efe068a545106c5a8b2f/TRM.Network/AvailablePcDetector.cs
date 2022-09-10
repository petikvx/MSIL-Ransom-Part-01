using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;

namespace TRM.Network;

public static class AvailablePcDetector
{
	public static List<string> FindShares(List<string> iplist)
	{
		List<string> list = new List<string>();
		try
		{
			foreach (string item in iplist)
			{
				try
				{
					ShareCollection shares = ShareCollection.GetShares(item);
					foreach (Share item2 in shares)
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

	public static List<string> FindActiveComputerInNetwork()
	{
		List<string> availableAddresses = new List<string>();
		List<string> appAddressesToScan = MyNetworkIpRanges();
		int numToWait = 0;
		List<Ping> disposePing = new List<Ping>();
		IAsyncResult asyncResult = ((ActionMethod)delegate
		{
			foreach (string item in appAddressesToScan)
			{
				Ping ping = new Ping();
				ping.PingCompleted += delegate(object sender, PingCompletedEventArgs e)
				{
					numToWait--;
					if (!e.Cancelled && e.Error == null && e.Reply!.Status == IPStatus.Success)
					{
						availableAddresses.Add(e.Reply!.Address.ToString());
					}
				};
				disposePing.Add(ping);
				ping.SendAsync(item, null);
				numToWait++;
				Thread.Sleep(10);
			}
		}).BeginInvoke(null, null);
		asyncResult.AsyncWaitHandle.WaitOne();
		while (numToWait > 0)
		{
			Thread.Sleep(100);
		}
		foreach (Ping item2 in disposePing)
		{
			item2.Dispose();
		}
		disposePing.Clear();
		return availableAddresses;
	}

	private static List<string> MyNetworkIpRanges()
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
			string text2 = IP4LastPartForm(text);
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

	private static string IP4LastPartForm(string ip4)
	{
		if (string.IsNullOrEmpty(ip4))
		{
			return ip4;
		}
		int num = ip4.LastIndexOf('.');
		if (num == -1)
		{
			return ip4;
		}
		return ip4.Substring(0, num + 1) + "{0}";
	}
}
