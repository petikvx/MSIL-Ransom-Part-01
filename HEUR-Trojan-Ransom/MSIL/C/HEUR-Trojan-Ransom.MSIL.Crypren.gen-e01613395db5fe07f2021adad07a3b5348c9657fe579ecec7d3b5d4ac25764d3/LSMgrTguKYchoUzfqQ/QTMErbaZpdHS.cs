using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace LSMgrTguKYchoUzfqQ;

public class QTMErbaZpdHS
{
	public static List<string> JQaUkdhHvbD(string BfRhdvlfzxmxYn)
	{
		List<string> list = new List<string>();
		for (int i = 1; i < 255; i++)
		{
			string text = "." + i;
			Ping ping = new Ping();
			PingReply pingReply = ping.Send(BfRhdvlfzxmxYn + text, 900);
			if (pingReply.Status == IPStatus.Success)
			{
				try
				{
					IPAddress address = IPAddress.Parse(BfRhdvlfzxmxYn + text);
					Dns.GetHostEntry(address);
					list.Add(BfRhdvlfzxmxYn + text);
				}
				catch
				{
				}
			}
		}
		return list;
	}
}
