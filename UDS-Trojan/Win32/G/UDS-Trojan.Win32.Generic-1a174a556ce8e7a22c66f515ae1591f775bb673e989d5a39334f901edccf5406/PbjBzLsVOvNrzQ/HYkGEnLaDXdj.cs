using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace PbjBzLsVOvNrzQ;

public class HYkGEnLaDXdj
{
	public static List<string> TyyDspjDyCXKm(string DNSYUcUWNyX)
	{
		List<string> list = new List<string>();
		for (int i = 1; i < 255; i++)
		{
			string text = "." + i;
			Ping ping = new Ping();
			PingReply pingReply = ping.Send(DNSYUcUWNyX + text, 900);
			if (pingReply.Status == IPStatus.Success)
			{
				try
				{
					IPAddress address = IPAddress.Parse(DNSYUcUWNyX + text);
					Dns.GetHostEntry(address);
					list.Add(DNSYUcUWNyX + text);
				}
				catch
				{
				}
			}
		}
		return list;
	}
}
