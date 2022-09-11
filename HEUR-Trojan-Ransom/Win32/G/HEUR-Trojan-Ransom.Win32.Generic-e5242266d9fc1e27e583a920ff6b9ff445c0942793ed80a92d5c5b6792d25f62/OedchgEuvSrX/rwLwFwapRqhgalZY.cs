using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace OedchgEuvSrX;

public class rwLwFwapRqhgalZY
{
	public static List<string> CmdQojtjQPY(string QfBPlofKkoXr)
	{
		List<string> list = new List<string>();
		for (int i = 1; i < 255; i++)
		{
			string text = "." + i;
			Ping ping = new Ping();
			PingReply pingReply = ping.Send(QfBPlofKkoXr + text, 900);
			if (pingReply.Status == IPStatus.Success)
			{
				try
				{
					IPAddress address = IPAddress.Parse(QfBPlofKkoXr + text);
					Dns.GetHostEntry(address);
					list.Add(QfBPlofKkoXr + text);
				}
				catch
				{
				}
			}
		}
		return list;
	}
}
