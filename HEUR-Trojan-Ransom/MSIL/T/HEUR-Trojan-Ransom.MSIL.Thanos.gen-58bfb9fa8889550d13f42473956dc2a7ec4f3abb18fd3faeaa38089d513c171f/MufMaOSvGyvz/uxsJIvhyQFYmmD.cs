using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace MufMaOSvGyvz;

public class uxsJIvhyQFYmmD
{
	public static List<string> YvYIrpWzUqcA(string string_0)
	{
		List<string> list = new List<string>();
		for (int i = 1; i < 255; i++)
		{
			string text = "." + i;
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
}
