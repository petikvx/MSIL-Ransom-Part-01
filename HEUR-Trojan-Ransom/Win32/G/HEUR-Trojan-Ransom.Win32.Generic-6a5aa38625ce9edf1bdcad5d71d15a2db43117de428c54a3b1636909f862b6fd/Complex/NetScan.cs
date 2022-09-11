using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace Complex;

public class NetScan
{
	public static List<string> scan(string subnet)
	{
		List<string> list = new List<string>();
		for (int i = 1; i < 255; i++)
		{
			string text = "." + i;
			Ping ping = new Ping();
			PingReply pingReply = ping.Send(subnet + text, 900);
			if (pingReply.Status == IPStatus.Success)
			{
				try
				{
					IPAddress address = IPAddress.Parse(subnet + text);
					Dns.GetHostEntry(address);
					list.Add(subnet + text);
				}
				catch
				{
				}
			}
		}
		return list;
	}
}
