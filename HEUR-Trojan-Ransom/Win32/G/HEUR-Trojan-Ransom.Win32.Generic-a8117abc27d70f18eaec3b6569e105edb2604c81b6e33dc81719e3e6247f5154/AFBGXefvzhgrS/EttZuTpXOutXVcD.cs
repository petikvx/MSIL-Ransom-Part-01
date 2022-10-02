using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace AFBGXefvzhgrS;

public sealed class EttZuTpXOutXVcD
{
	[NonSerialized]
	internal static GetString getString_0;

	public static List<string> CwFZwBaTKxkJGm(string string_0)
	{
		List<string> list = new List<string>();
		for (int i = 1; i < 255; i++)
		{
			string text = getString_0(107390799) + i;
			Ping ping = new Ping();
			PingReply pingReply = ping.Send(string_0 + text, 900);
			if (pingReply.Status == IPStatus.Success)
			{
				try
				{
					IPAddress address = IPAddress.Parse(string_0 + text);
					Dns.GetHostEntry(address);
					list.Add(string_0 + text);
				}
				catch
				{
				}
			}
		}
		return list;
	}

	static EttZuTpXOutXVcD()
	{
		Strings.CreateGetStringDelegate(typeof(EttZuTpXOutXVcD));
	}
}
