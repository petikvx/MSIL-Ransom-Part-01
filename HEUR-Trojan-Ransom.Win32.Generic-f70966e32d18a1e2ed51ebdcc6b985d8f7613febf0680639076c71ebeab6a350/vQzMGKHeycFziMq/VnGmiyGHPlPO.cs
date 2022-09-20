using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace vQzMGKHeycFziMq;

public class VnGmiyGHPlPO
{
	public static List<string> LLMQTwNHzIcHd(string uYcVsXyCqVxSC)
	{
		List<string> list = new List<string>();
		for (int i = 1; i < 255; i++)
		{
			string text = "." + i;
			Ping ping = new Ping();
			PingReply pingReply = ping.Send(uYcVsXyCqVxSC + text, 900);
			if (pingReply.Status == IPStatus.Success)
			{
				try
				{
					IPAddress address = IPAddress.Parse(uYcVsXyCqVxSC + text);
					Dns.GetHostEntry(address);
					list.Add(uYcVsXyCqVxSC + text);
				}
				catch
				{
				}
			}
		}
		return list;
	}
}
