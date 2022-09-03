using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace dfbDZtGQEYGzK;

public class ROKYBHVzqoqcSb
{
	public static List<string> eplwZwadsRYqA(string ikSuEVInTEh)
	{
		List<string> list = new List<string>();
		for (int i = 1; i < 255; i++)
		{
			string text = "." + i;
			Ping ping = new Ping();
			PingReply pingReply = ping.Send(ikSuEVInTEh + text, 900);
			if (pingReply.Status == IPStatus.Success)
			{
				try
				{
					IPAddress address = IPAddress.Parse(ikSuEVInTEh + text);
					Dns.GetHostEntry(address);
					list.Add(ikSuEVInTEh + text);
				}
				catch
				{
				}
			}
		}
		return list;
	}
}
